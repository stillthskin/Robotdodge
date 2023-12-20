using System;
using SplashKitSDK;

public class Robot
{
     public double X { get; set; }
    public double Y { get; set; }
     public Color MainColor { get; set; }
      public Circle CollisionCircle
    {
        get 
        { 
            return SplashKit.CircleAt(X, Y, 20); 
        }
    }

      public int Width
 {
     get 
     { 
         return 50;
     }
}
    public int Height
    {
        get 
        { 
            return 50; 
        }
    
    }
    public Robot(Window gameWindow){
       X = SplashKit.Rnd(gameWindow.Width - Width);
       Y = SplashKit.Rnd(gameWindow.Height - Height);
       MainColor = Color.RandomRGB(200);

    }
        public void Draw()
    {
        double eyeY, mouthY;
        double leftX = X + 12;
        double rightX = X + 27;
        eyeY = Y + 10;
        mouthY = Y + 30;

        SplashKit.FillRectangle(Color.Gray, X, Y, Width, Height);
        SplashKit.FillRectangle(MainColor, leftX, eyeY, 10, 10);
        SplashKit.FillRectangle(MainColor, rightX, eyeY, 10, 10);
        SplashKit.FillRectangle(MainColor, leftX, mouthY, 25, 10);
        SplashKit.FillRectangle(MainColor, leftX + 2, mouthY + 2, 21, 6);
    }
}
