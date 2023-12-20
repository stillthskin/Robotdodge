using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window myWindow = new Window("Robot Dodge", 800, 420);
        RobotDodge game = new RobotDodge(myWindow);
        while (!myWindow.CloseRequested)
        {
            game.HandleInput();
            game.Draw();
            game.Update();
        }
    }
}
