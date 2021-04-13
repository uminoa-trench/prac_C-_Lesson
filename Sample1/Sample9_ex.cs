using System;
using System.Windows.Forms;
using System.Drawing;

class Sample9_ex : Form
{
    private int t;

    public static void Main()
    {
        Application.Run(new Sample9_ex());
    }

    public Sample9_ex()
    {
        this.Text = "サンプル";
        this.ClientSize = new Size(200, 200);
        this.DoubleBuffered = true;

        t = 0;

        Timer tm = new Timer();
        tm.Interval = 100;
        tm.Start();

        this.Paint += new PaintEventHandler(fm_Paint);
        tm.Tick += new EventHandler(tm_Tick);
    }

    public void fm_Paint(Object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;

        int w = this.ClientSize.Width;
        int h = this.ClientSize.Height;

        g.FillEllipse(new SolidBrush(Color.DeepPink),
            0, 0, w, h);                                //未経過時間分の楕円 

        g.FillPie(new SolidBrush(Color.DarkOrchid),
            0, 0, w, h, -90, (float)0.6*t);             //未経過時間分の楕円 

        g.FillEllipse(new SolidBrush(Color.Bisque),
            (int)w / 4, (int)h / 4, (int)w / 2, (int)h / 2);                                //中心部分の楕円

        string time = t / 10 + ":" + "0" + t % 10; //経過時間をあらわす文字列

        Font f = new Font("Courier", 20);
        SizeF ts = g.MeasureString(time, f);// 指定フォントで表示した場合のサイズを調査

        float tx = (w - ts.Width) / 2;
        float ty = (h - ts.Height) / 2;

        g.DrawString(time, f, new SolidBrush(Color.Black),tx, ty);

    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        t = t + 1;
        if(t > 600)//１分経過後
        {
            t = 0;//最初に戻る
        }

        this.Invalidate();
    }
}