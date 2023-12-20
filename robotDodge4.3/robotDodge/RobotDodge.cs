using System;
using SplashKitSDK;

public class RobotDodge
{
   private Player _Player;
    private Window _GameWindow;

    private Robot _testRobot;
      public bool Quit
    {
        get
        {
            return _Player.Quit;
        }
    }
     public RobotDodge(Window window)
    {
        _testRobot = new Robot(window);
         _GameWindow = window;
        _Player = new Player(window);
    }
     public void HandleInput()
    {
        _Player.HandleInput();
        _Player.StayOnWindow(_GameWindow);
    }
    public void Draw()
    {
    _GameWindow.Clear(Color.White);
    _Player.Draw();
    _GameWindow.Refresh(60);

    }
     public void Update()
    {
      if(_Player.CollidedWith(_testRobot)){
        _testRobot = RandomRobot();
      }

    }
      public Robot RandomRobot()
    {
    Robot _RandomRobot = new Robot(_GameWindow);
    return _RandomRobot;
    
    }

  

}
