# Udon Record player
By [Vard](https://twitter.com/VardFree) and [Temmie Dola](https://twitter.com/Temmie_Dola)
## An interactive vinyl record player for vrchat
- Inspired by [Tanuki Tunesǃ](https://vrchat.com/home/world/wrld_033b9f75-49be-4213-9218-a540dd2be60a) world 
- You can visit [Example world](https://vrchat.com/home/world/wrld_033b9f75-49be-4213-9218-a540dd2be60a) to try it out by yourself
## Installation
1. Install the latest [VRCSDK3](https://vrchat.com/home/download), [UdonSharp](https://github.com/MerlinVR/UdonSharp) and [USharpVideo](https://github.com/MerlinVR/USharpVideo) packages
2. Import [Udon_Record_Player.unitypackage](https://github.com/Vard-and-Temmie/Udon-Record-player/releases) to your unity project
3. Drag USharpVideo(if you dont have one already) and Record_Player prefabs into your scene
4. Drag "USharpVideo" and "Internals" gameobjects to fields with the same names in Record_Player gameobject ![image](https://i.imgur.com/dnRKF2u.png)
5. Drop ExampleVinyl prefabs into your scene and fill out `Vinyl_list` fields with them ![image](https://i.imgur.com/rVyibcY.png)
6. Done!

## How to add your own vinyl records?
1. First of all you need to make a texture of your vinyl. We provided Example.PSD in Example vinyls folder to make it easier for you <3
2. Create material with your texture (we recommend duplicating one of the example vinyl materials cause they have PBR maps for more realistic look)
3. Drop one of the ExampleVinyl prefabs into scene and change its material and name to your own
4. Increase array size of `Vinyl_list` and `Vinyl_url` in Record_Player gameobject by 1 and apply your new vinyl gameobject and url to them ![image](https://i.imgur.com/ID4zMny.png)
5. Done!
## Tips
- We recommend you locking your USharpVideo player by default for public worlds to prevent chaos of constantly changing music by random users.
- You can easily personalize player look by just changing albedo color in material settings. ![image](https://i.imgur.com/GRcwUHi.png)
