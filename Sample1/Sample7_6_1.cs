using System;
using System.Windows.Forms;

class Sample7_6_1 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample7_6_1());
    }

    public Sample7_6_1()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 200;

        lb = new Label();
        lb.Text = "いらっしゃいませ";
        lb.Dock = DockStyle.Top;

        bt = new Button();
        bt.Text = "購入";
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;

        bt.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        SampleForm sf = new SampleForm();
        //sf.ShowDialog();
        sf.Show();
    }

}

class SampleForm : Form
{
    public SampleForm()
    {
        Label lb = new Label();
        Button bt = new Button();

        this.Text = "御礼";
        this.Width = 250; this.Height = 200;

        lb.Text = "ありがとうございました。";
        lb.Dock = DockStyle.Top;

        bt.Text = "OK";
        bt.DialogResult = DialogResult.OK;
        bt.Dock = DockStyle.Bottom;

        lb.Parent = this;
        bt.Parent = this;
    }

}