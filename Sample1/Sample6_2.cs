using System;
using System.Windows.Forms;

class Sample6_2 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample6_2());
    }

    public Sample6_2()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 200;

        lb = new Label();
        lb.Text = "ようこそ";
        lb.Width = 150;

        bt = new Button();
        bt.Text = "購入";
        bt.Top = this.Top + lb.Height;
        bt.Width = lb.Width;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void fm_Click(Object sender, EventArgs e)
    {
        lb.Text = "こんにちは";
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        lb.Text = "ありがとうございます。";
    }
}