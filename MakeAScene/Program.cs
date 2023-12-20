using System;
using SplashKitSDK;

public class Program
{

    public static void Main()
    {
       Window myWindow = new Window("Make A Scene", 600, 600);
       SoundEffect sounds = new SoundEffect("Coin sound", "resources/sound/coin.wav");
       Bitmap HiEmoji = new Bitmap("Emoji", "resources/images/hi.jpg");
       Bitmap SecondEmoji = new Bitmap("Cool Emoji", "resources/images/hello.png");


       myWindow.Clear(Color.White);
       myWindow.DrawBitmap(HiEmoji, 30, 30);
       myWindow.Refresh(30);
       sounds.Play();
       SplashKit.Delay(1000);
       myWindow.Clear(Color.White);
       myWindow.DrawBitmap(SecondEmoji, 30, 30);
       myWindow.Refresh();
       SplashKit.Delay(300);

    }
}
