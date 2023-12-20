using System;
using SplashKitSDK;

public class Bullet
{
    private Bitmap _BulletBitmap;
    private double X { get; set; }
    private double Y { get; set; }

    private Vector2D Velocity { get; set; }

    public int Width
    {
        get { return _BulletBitmap.Width; }
    }
    public int Height
    {
        get { return _BulletBitmap.Height; }
    }


    public Bullet(Window gameWindow, Player _Player)
    {
        _BulletBitmap = new Bitmap("Bullet", "Fire.png");

        const int SPEED = 8;
        X = _Player.X + _Player.Width/2;
        Y = _Player.Y + _Player.Height/2;
        Point2D fromPt = new Point2D()
        {
            X = X,
            Y = Y
        };

        Point2D mousePt = SplashKit.MousePosition();

        Vector2D dir;
        dir = SplashKit.UnitVector(SplashKit.VectorPointToPoint(fromPt, mousePt));

        Velocity = SplashKit.VectorMultiply(dir, SPEED);
    }

    public void Draw()
    {
        SplashKit.ProcessEvents();
        SplashKit.DrawBitmap(_BulletBitmap, X, Y);
    }
     public void Update()
    {
        X = X + Velocity.X;
        Y = Y + Velocity.Y;
    }
    public bool IsOffscreen(Window screen)
    {
        return (X < -Width || X > screen.Width || Y < -Height || Y > screen.Height);
    }
    public bool BulletCollidedWith(Robot robot)
    {
        return _BulletBitmap.CircleCollision(X, Y, robot.CollisionCircle);
    }

}