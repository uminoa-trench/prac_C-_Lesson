using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

class Sample8_2_1 : Form
{
    private List<Point> ls;

    public static void Main()
    {
        Application.Run(new Sample8_2_1());
    }

    public Sample8_2_1()
    {
        this.Text = "サンプル";

        ls = new List<Point>();


        this.MouseDown += new MouseEventHandler(fm_MouseDown);
        this.Paint += new PaintEventHandler(fm_Paint);
    }

    public void fm_MouseDown(Object sender, MouseEventArgs e)
    {
        Point p = new Point();
        p.X = e.X;
        p.Y = e.Y;
        ls.Add(p);
        this.Invalidate();
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Pen dp = new Pen(Color.Black, 1);

        foreach(Point p in ls)
        {
            g.DrawEllipse(dp, p.X, p.Y, 10, 10);
        }
    }
}

