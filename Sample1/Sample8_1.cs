using System;
using System.Windows.Forms;
using System.Drawing;

class Sample8_1 : Form
{
    private Image im;

    public static void Main()
    {
        Application.Run(new Sample8_1());
    }

    public Sample8_1()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 200;

        im = Image.FromFile("C:\\image\\image2.jpg");

        this.Click += new EventHandler(fm_Click);
        this.Paint += new PaintEventHandler(fm_Paint);
    }

    public void fm_Click(Object sender, EventArgs eventArgs)
    {
        im.RotateFlip(RotateFlipType.Rotate90FlipNone);//画像を回転
        this.Invalidate();//回転して再描画
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        g.DrawImage(im, 0, 0);
    }

}

