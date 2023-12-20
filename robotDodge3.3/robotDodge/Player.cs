using System;
using SplashKitSDK;


public class Player{
    private Bitmap _PlayerBitmap;
    public double X { get; private set; }
    public double Y { get; private set; }
    public bool Quit { get; private set; }
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
        Quit = false;
        _PlayerBitmap = new Bitmap("Player", "resources/Player.png");
        X = (gameWindow.Width - Width) / 2;
        Y = (gameWindow.Width - Height) / 2;
    }
      public void Draw()
    {
        SplashKit.ProcessEvents();
        HandleInput();
        SplashKit.DrawBitmap(_PlayerBitmap, X, Y);
    }
        public void HandleInput()
    {

        const int SPEED = 5;

        if (SplashKit.KeyDown(KeyCode.RightKey))
        {
            X = X + SPEED;
        }
        else if (SplashKit.KeyDown(KeyCode.LeftKey))
        {
            X = X - SPEED;
        }
        else if (SplashKit.KeyDown(KeyCode.UpKey))
        {
            Y = Y - SPEED;
        }
        else if (SplashKit.KeyDown(KeyCode.DownKey))
        {
            Y = Y + SPEED;
        }
        if (SplashKit.KeyDown(KeyCode.EscapeKey))
        {
            Quit = true;
        }
    }
        public void StayOnWindow(Window gameWindow)
    {
        const int GAP = 10;

        if (X < GAP)
        {
            X = GAP;
        }
        else if (X > gameWindow.Width - GAP - Width)
        {
            X = gameWindow.Width - GAP - Width;
        }
        else if (Y < GAP)
        {
            Y = GAP;
        }
        else if (Y > gameWindow.Height - GAP - Height)
        {
            Y = gameWindow.Height - GAP - Height;
        }

    }



}