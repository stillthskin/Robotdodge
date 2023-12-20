using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window myWindow = new Window("Robot Dodge", 600, 600);
        Player newplaye = new Player(myWindow);
        myWindow.Clear(Color.White);
        newplaye.Draw();
        SplashKit.Delay(1000);
        myWindow.Refresh(60);
    }
}
