<p align="center"><img src="https://i.ibb.co/Pj3P8Ms/tarkovlens-logo.png" alt="TarkovLensDiscordBotLogo" width="30%" height="30%" /></p>
<h1 align="center">TarkovLens Discord Bot</h1>

<p align="center">An Escape from Tarkov Discord bot that provides market prices, ammo comparison tables and information on various types of in-game items.</p>

## Command Usage
|     Command    | Shorthand | Description                                                                                        | Example                                    |
|:--------------:|-----------|----------------------------------------------------------------------------------------------------|--------------------------------------------|
| `!price`       | `!p`      | Gets the market price of an item.                                                                  | `!price salewa`                            |
| `!ammo`        | -         | Get information about an ammunition. Ammunition can be found using caliber and name, or just name. | `!ammo 5.56 m995`                          |
| `!compareammo` | `!cammo`  | Compare multiple ammunitions. Each ammunition must be provided with the caliber and the name.      | `!compareammo 5.56 m995, 5.45 bt, 9x19 ap` |
| `!caliber`     | -         | Get information about all the ammunition of a certain caliber.                                     | `!caliber 9x19`                            |
| `!armor`       | -         | Get information about an armor.                                                                    | `!armor zhuk-6a`                           |
| `!medical`     | `!med`    | Get information about a medical item or stimulant.                                                 | `!medical salewa`                          |
| `!key`         | `!k`      | Get information about a key.                                                                       | `!key factory`                             |
| `!map`         | -         | Get a map for a location.                                                                          | `!map customs`                             |

## Screenshots
<p align="center"><img src="https://i.ibb.co/vDy0Lpk/tl-screenshot1.png" alt="PriceCommandScreenshot" width="25%" height="25%" /></p>
<p align="center"><img src="https://i.ibb.co/bHxY67z/tl-screenshot2.png" alt="AmmoCommandScreenshot" width="30%" height="30%" /></p>
<p align="center"><img src="https://i.ibb.co/LJdnfCP/tl-screenshot3.png" alt="KeyCommandScreenshot" width="40%" height="40%" /></p>
<p align="center"><img src="https://i.ibb.co/1bj5hNY/tl-screenshot4.png" alt="CompareammoCommandScreenshot" width="65%" height="65%" /></p>

## Thanks

Big thanks to [Morphy2k](https://www.reddit.com/user/Morphy2k) for all the work he does - without him this project wouldn't exist.

Check out his work here: [Tarkov-Database](https://tarkov-database.com/)

## Tools
Built with C# .Net Core 3.1 and the DSharpPlus Nuget package.
