using System;
using System.Windows.Forms;

class Sample6_1_2 : Form
{
    private Label lb;

    public static void Main()
    {
        Application.Run(new Sample6_1_2());
    }

    public Sample6_1_2()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 200;

        lb = new Label();
        lb.Text = "ようこそ";

        lb.Parent = this;

        this.MouseEnter += new EventHandler(fm_MouseEnter);//カーソルが入ったとき
        this.MouseLeave += new EventHandler(fm_MouseLeave);//カーソルが出たとき
    }

    public void fm_MouseEnter(Object sender, EventArgs e)
    {
        lb.Text = "こんにちは";
    }

    public void fm_MouseLeave(Object sender, EventArgs e)
    {
        lb.Text = "さようなら";
    }
}