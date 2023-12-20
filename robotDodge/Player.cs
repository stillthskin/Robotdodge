using System;
using SplashKitSDK;


public class Player{
    private Bitmap _PlayerBitmap;
    public double X { get; private set; }
    public double Y { get; private set; }
     public int Width
    {
        get { 
            return _PlayerBitmap.Width; 
            }
    }
     public int Height
    {
        get { 
            return _PlayerBitmap.Height; 
            }
    }
      public Player(Window gameWindow)
    {
        //Quit = false;
        _PlayerBitmap = new Bitmap("Player", "resources/Player.png");
        X = (gameWindow.Width - Width) / 2;
        Y = (gameWindow.Width - Height) / 2;
    }
      public void Draw()
    {
        SplashKit.DrawBitmap(_PlayerBitmap, X, Y);
    }



}