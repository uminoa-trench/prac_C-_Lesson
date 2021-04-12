using System;
using System.Windows.Forms;
using System.Drawing;

class Sample8_4_2 : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample8_4_2());
    }

    public Sample8_4_2()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 100;

        Timer tm = new Timer();
        tm.Interval = 1000;//1秒
        tm.Start();

        lb = new Label();
        lb.Font = new Font("Courier", 20, FontStyle.Regular);
        lb.Dock = DockStyle.Fill;

        lb.Parent = this;

        tm.Tick += new EventHandler(tm_Tick);
    }

    public void tm_Tick(Object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;

        lb.Text = dt.ToLongTimeString();//現在時刻に設定

    }
}