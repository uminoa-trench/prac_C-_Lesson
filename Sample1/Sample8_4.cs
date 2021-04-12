using System;
using System.Windows.Forms;
using System.Drawing;

class Sample8_4 : Form
{
    private MyBall bl;
    private int dx, dy;

    public static void Main()
    {
        Application.Run(new Sample8_4());
    }

    public Sample8_4()
    {
        this.Text = "サンプル";
        this.ClientSize = new Size(250, 200);

        bl = new MyBall();

        Point p = new Point(0, 0);
        Color c = Color.Blue;

        bl.Point = p;
        bl.Color = c;

        dx = 2;
        dy = 2;

        Timer tm = new Timer();
        tm.Interval = 100;
        tm.Start();

        this.Paint += new PaintEventHandler(fm_Paint);
        tm.Tick += new EventHandler(tm_Tick);
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        Point p = bl.Point;
        Color c = bl.Color;
        SolidBrush br = new SolidBrush(c);
        g.FillEllipse(br, p.X, p.Y, 10, 10);
    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        Point p = bl.Point;

        if (p.X < 0 || p.X > this.ClientSize.Width - 10)//横壁にぶつかったら
        {
            dx = -dx;
        }

        if (p.Y < 0 || p.Y > this.ClientSize.Height - 10)//縦壁にぶつかったら
        {
            dy = -dy;
        }

        p.X += dx;
        p.Y += dy;

        bl.Point = p;
        this.Invalidate();
    }
}