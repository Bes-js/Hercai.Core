using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hercai
{
    public class Hercai
    {
        private readonly string apiKey;
        private static readonly string[] imageSourceArray = ["v1", "v2", "v2-beta", "v3", "lexica", "prodia", "simurg", "animefy", "raava", "shonin"];
        private static readonly string[] chatSourceArray = ["v3", "gemini", "v3-32k", "turbo", "turbo-16k"];

        public Hercai(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey) || typeof(string) != apiKey.GetType())
            {
                this.apiKey = "";
            }
            else
            {
                this.apiKey = apiKey;
            }
        }

        public static async Task<string> Question(string model = "v3", string content = "")
        {
            if (!chatSourceArray.Contains(model))
            {
                model = "v3";
            }

            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentException("Please specify a question!");
            }

            try
            {
                using var httpClient = new HttpClient();
                var response = await httpClient.GetAsync($"https://hercai.onrender.com/{model}/hercai?question=" + Uri.EscapeDataString(content));
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public static async Task<string> DrawImage(string model = "simurg", string prompt = "", string negativePrompt = "")
        {
            if (!imageSourceArray.Contains(model))
            {
                model = "simurg";
            }

            if (string.IsNullOrEmpty(prompt))
            {
                throw new ArgumentException("Please specify a prompt!");
            }

            if (string.IsNullOrEmpty(negativePrompt))
            {
                negativePrompt = "";
            }

            try
            {
                using var httpClient = new HttpClient();
                var response = await httpClient.GetAsync($"https://hercai.onrender.com/{model}/text2image?prompt=" + Uri.EscapeDataString(prompt) + "&negative_prompt=" + Uri.EscapeDataString(negativePrompt));
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}