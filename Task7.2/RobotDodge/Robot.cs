using System;
using SplashKitSDK;

public abstract class Robot
{
    public double X { get; set; }
    public double Y { get; set; }
    public Color MainColor { get; set; }

    private Vector2D Velocity { get; set; }
    public Circle CollisionCircle
    {
        get { return SplashKit.CircleAt(X, Y, 20); }
    }

   public int Width
   {
   get { return 50; }
   }
    public int Height
    {
        get { return 50; }
    }
    public Robot(Window gameWindow, Player player)
    {
        if (SplashKit.Rnd() < 0.5)
        {
    
            X = SplashKit.Rnd(gameWindow.Width);

            if (SplashKit.Rnd() < 0.5)
            {
                Y = -Height; 
            }
            else
            {
                Y = gameWindow.Height;
            }
        }
        else
        {
            Y = SplashKit.Rnd(gameWindow.Height);

            if (SplashKit.Rnd() < 0.5)
            {
                X = -Width;
            }
            else
            {
                X = gameWindow.Width;
            }
        }

        const int SPEED = 4;

        Point2D fromPt = new Point2D()
        {
            X = X,
            Y = Y
        };

        Point2D toPt = new Point2D()
        {
            X = player.X,
            Y = player.Y
        };

        Vector2D dir;
        dir = SplashKit.UnitVector(SplashKit.VectorPointToPoint(fromPt, toPt));

        Velocity = SplashKit.VectorMultiply(dir, SPEED);
        MainColor = Color.RandomRGB(200);

    }
    public bool IsOffscreen(Window screen)
    {
        return (X < -Width || X > screen.Width || Y < -Height || Y > screen.Height);
    }
    public abstract void Draw();
    public void Update()
    {
        X = X + Velocity.X;
        Y = Y + Velocity.Y;
    }
}

public class Boxy : Robot
{
    public Boxy(Window gameWindow, Player player) : base(gameWindow, player)
    {

    }
    public override void Draw()
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

public class Roundy : Robot
{
    public Roundy(Window gameWindow, Player player) : base(gameWindow, player)
    {
    }
    public override void Draw()
    {
        double leftX, midX, rightX;
        double midY, eyeY, mouthY;

        leftX = X + 17;
        midX = X + 25;
        rightX = X + 33;

        midY = Y + 25;
        eyeY = Y + 20;
        mouthY = Y + 35;

        SplashKit.FillCircle(Color.White, midX, midY, 25);
        SplashKit.DrawCircle(Color.Gray, midX, midY, 25);
        SplashKit.FillCircle(MainColor, leftX, eyeY, 5);
        SplashKit.FillCircle(MainColor, rightX, eyeY, 5);
        SplashKit.FillEllipse(Color.Gray, X, eyeY, 50, 30);
        SplashKit.DrawLine(Color.Black, X, mouthY, X + 50, Y + 35);
    }
}
public class Custom : Robot
{
    public Custom(Window gameWindow, Player player) : base(gameWindow, player)
    {
    }
    public override void Draw()
    {
        double leftX, midX, rightX;
        double midY, eyeY, mouthY;

        leftX = X + 17;
        midX = X + 25;
        rightX = X + 33;

        midY = Y + 25;
        eyeY = Y + 20;
        mouthY = Y + 35;

        SplashKit.FillCircle(Color.Red, midX, midY, 25);
        SplashKit.FillCircle(Color.Blue, midX, midY, 20);
        SplashKit.FillCircle(Color.Green, midX, midY, 15);
        SplashKit.FillCircle(Color.Yellow, midX, midY, 10);
        SplashKit.FillCircle(Color.White, midX, midY, 5);
    }
}
