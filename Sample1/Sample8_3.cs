using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

class Sample8_3 : Form
{
    private List<MyBall> ls;

    public static void Main()
    {
        Application.Run(new Sample8_3());
    }
    public Sample8_3()
    {
        this.Text = "サンプル";
        this.Paint += new PaintEventHandler(fm_Paint);

        ls = new List<MyBall>();

        Random rn = new Random();

        for (int i = 0; i < 30; i++)
        {
            MyBall bl = new MyBall();

            int x = rn.Next(this.Width);
            int y = rn.Next(this.Height);

            int r = rn.Next(256);
            int g = rn.Next(256);
            int b = rn.Next(256);

            Point p = new Point(x, y);
            Color c = Color.FromArgb(r, g, b);

            bl.Point = p;
            bl.Color = c;

            ls.Add(bl);

        }
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        foreach (MyBall bl in ls)
        {
            Point p = bl.Point;
            Color c = bl.Color;
            SolidBrush br = new SolidBrush(c);

            g.FillEllipse(br, p.X, p.Y, 10, 10);
        }
    }

}

class MyBall
{
    public Color Color;
    public Point Point;
}