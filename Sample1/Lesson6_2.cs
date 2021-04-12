using System;
using System.Windows.Forms;

class Lesson6_2 : Form
{
    private Button bt;

    public static void Main()
    {
        Application.Run(new Lesson6_2());
    }

    public Lesson6_2()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 200;

        bt = new Button();
        bt.Text = "ようこそ";
        bt.Width = 150;

        bt.Parent = this;

        bt.MouseEnter += new EventHandler(bt_MouseEnter);
        bt.MouseLeave += new EventHandler(bt_MouseLeave);
    }

    public void bt_MouseEnter(Object sender, EventArgs e)
    {
        bt.Text = "こんにちは";
    }

    public void bt_MouseLeave(Object sender, EventArgs e)
    {
        bt.Text = "さようなら";
    }
}