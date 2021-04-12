using System;
using System.Windows.Forms;

class Sample6_1 : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample6_1());
    }

    public Sample6_1()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 200;

        lb = new Label();
        lb.Text = "ようこそ";

        lb.Parent = this;

        this.Click += new EventHandler(fm_Click);
    }

    public void fm_Click(Object sender, EventArgs e)
    {
        lb.Text = "こんにちは";
    }
}