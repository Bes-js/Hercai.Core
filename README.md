<p align="center"> <a href="#"> <img width=500 src="https://raw.githubusercontent.com/Bes-js/herc.ai/main/hercai-logo.png"></a></p> 
<p align="center"> <img src="https://img.shields.io/github/repo-size/Bes-js/Hercai.Core?style=for-the-badge"> <img src="https://img.shields.io/github/contributors/Bes-js/Hercai.Core?style=for-the-badge"> <a href="https://discord.gg/luppux" target="_blank"> <img alt="Discord" src="https://img.shields.io/badge/Support-Click%20here-7289d9?style=for-the-badge&logo=discord"> </a><a href="https://www.buymeacoffee.com/beykant" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" width="120px" height="30px" alt="Buy Me A Coffee"></a></p>

# [Herc.ai](https://discord.gg/luppux)

> **A powerful library for interacting with the [Herc.ai](https://discord.gg/luppux) API.**

> **We Offer It To You For Free.**
> **[Herc.ai](https://discord.gg/luppux) Answers Your Question According To The Language, And It Supports All Languages.**

> **[✨ How about a one-time subscription to benefit from Hercai's features unlimitedly?](https://hercai-shop.onrender.com)**
**[✨ Use Hercai Unlimited with API Key!](https://hercai-shop.onrender.com)**
#
### ❔ [Support](https://discord.gg/luppux)
### 📂 [Nuget]()
### 📝 [Github](https://github.com/Bes-js/Hercai.Core)
#
#
**📂 Installation**
```lua
Install-Package Hercai

dotnet add package Hercai
```
#
# Quick Example

**Exampe Construction;**
```cs
 string apiKey = ""; /* If you have a Hercai API Key, please define it in this section. */
 Hercai hercaiInstance = new Hercai(apiKey);
```
 
 > **Question API; [https://hercai.onrender.com/v3/hercai?question=](https://hercai.onrender.com/v3/hercai?question=)**

**Example Question For .NET Core;**
```cs
/* Available Models */
/* "v3" , "v3-32k" , "turbo" , "turbo-16k" , "gemini" */
/* Default Model; "v3" */
string questionModel = "v3";
string questionContent = "What is the meaning of life?";
string questionResponse = await Hercai.Question("v3", "hi, how are you?");
Console.WriteLine("Question Response: " + questionResponse);
```
#

> **Text To Image API; [https://hercai.onrender.com/v3/text2image?prompt=](https://hercai.onrender.com/v3/text2image?prompt=)**

**Example Draw Image For .NET Core;**
```cs
/* Available Models */
/* "v1" , "v2" , "v2-beta" , "v3" (DALL-E) , "lexica" , "prodia", "simurg", "animefy", "raava", "shonin" */
/* Default Model; "v3" */
string imageModel = "simurg";
string prompt = "A beautiful landscape";
string negativePrompt = "Dark and gloomy"; /* Optional Prompt, If None, Leave Blank. */
string imageResponse = await Hercai.DrawImage(imageModel, prompt, negativePrompt);
Console.WriteLine("Image Response: " + imageResponse);
            
```

#
# Credits
 
**[NPM Package For JavaScript & TypeScript](https://www.npmjs.com/package/hercai)**
#
**Made by [FiveSoBes](https://github.com/Bes-js) And [Luppux Development](https://github.com/Luppux)**


# Contact & Support & Donate
<a href="https://www.buymeacoffee.com/beykant" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" width="120px" height="30px" alt="Buy Me A Coffee"></a>

[![Discord Banner](https://api.weblutions.com/discord/invite/luppux/)](https://discord.gg/luppux)
