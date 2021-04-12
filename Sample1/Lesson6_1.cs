using System;
using System.Windows.Forms;

class Lesson6_1 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Lesson6_1());
    }

    public Lesson6_1()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 200;

        lb = new Label();
        lb.Text = "いらっしゃいませ";
        lb.Width = 150;

        bt = new Button();
        bt.Text = "購入";
        bt.Top = this.Top + lb.Height;
        bt.Width = lb.Width;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        bt.Text = "ありがとうございます。";
    }
}