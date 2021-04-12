using System;
using System.Windows.Forms;

class Sample7_3_2 : Form
{
    private Label lb;
    private RadioButton rb1, rb2;
    private GroupBox rb;

    public static void Main()
    {
        Application.Run(new Sample7_3_2());
    }

    public Sample7_3_2()
    {
        this.Text = "サンプル";
        this.Width = 300; this.Height = 200;

        lb = new Label();
        lb.Text = "いらっしゃいませ";
        lb.Dock = DockStyle.Top;

        rb1 = new RadioButton();
        rb2 = new RadioButton();

        rb1.Text = "車";
        rb2.Text = "トラック";
        rb1.Checked = true;

        rb1.Dock = DockStyle.Left;
        rb2.Dock = DockStyle.Right;

        rb = new GroupBox();
        rb.Text = "種類";
        rb.Dock = DockStyle.Bottom;

        rb1.Parent = rb;
        rb2.Parent = rb;

        lb.Parent = this;
        rb.Parent = this;

        rb1.Click += new EventHandler(rb_Click);
        rb2.Click += new EventHandler(rb_Click);
    }

    public void rb_Click(Object sender, EventArgs e)
    {
        RadioButton tmp = (RadioButton)sender;
        lb.Text = tmp.Text + "を選びました";
    }
}