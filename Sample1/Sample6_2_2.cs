using System;
using System.Windows.Forms;

class Sample6_2_2 : Form
{
    private Label lb, lb1 ;

    public static void Main()
    {
        Application.Run(new Sample6_2_2());
    }

    public Sample6_2_2()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 200;

        lb = new Label();
        lb.Text = "矢印キーで選んでください";
        lb.Width = this.Width;

        lb1 = new Label();
        lb1.Top = lb1.Bottom;

        lb.Parent = this;
        lb1.Parent = this;

        this.KeyDown += new KeyEventHandler(fm_KeyDown);
    }

    public void fm_KeyDown(Object sender, KeyEventArgs e)
    {
        string str;

        if (e.KeyCode == Keys.Up)
        {
            str = "上";
        }
        else if (e.KeyCode == Keys.Down)
        {
            str = "下";
        }
        else if (e.KeyCode == Keys.Right)
        {
            str = "右";
        }
        else if (e.KeyCode == Keys.Left)
        {
            str = "左";
        }
        else
        {
            str = "ほかのキー";
        }

        lb1.Text = str + "ですね。";
    }
}