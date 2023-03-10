# 복사본

github actions를 이용한 컴파일용입니다.

# KartPainter

[The most ridiculous attempt to make sharing decals _slightly_ easier.](https://www.youtube.com/watch?v=tgYhuaACxwg)

How does it work?

- Write down the decal parts you want to share in decal script format - examples are found in the
  `src/KartPainter/Scripts` folder (partial automated export not written yet, sorry).
- Go to the "Create Decals" screen in your game (the one showing an empty "New Decal" area).
- Run the tool and select the decal you want it to paint.
- Optionally, choose a color to use instead of the ones defined in the script.
- Click "Paint!" and wait for the tool sending keyboard inputs to your game to recreate it. You can use other apps
  meanwhile - just don't interact with the game or make it lag too much.

For now, this is super experimental and was barely tested with the English version of the game. This means no support,
no warranty, accidental corruption of other decals from stray inputs. You may get banned for using this. Compile the
tool yourself (Visual Studio 2022 + .NET Framework 4.8.1 SDK required).

Of course, you can also just wait until copying / sharing is introduced officially. If you think you still live by then.
