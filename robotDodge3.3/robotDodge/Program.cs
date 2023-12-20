using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window myWindow = new Window("Robot Dodge", 600, 600);
        Player newplayer = new Player(myWindow);
        while (!myWindow.CloseRequested)
        {
        myWindow.Clear(Color.White);
        newplayer.Draw();
        SplashKit.Delay(1000);
        myWindow.Refresh(60);
        }
    }
}
