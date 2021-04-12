using System;
using System.Windows.Forms;

class Sample7_6 : Form
{
    private Label lb;
    private Button bt;

    public static void Main()
    {
        Application.Run(new Sample7_6());
    }

    public Sample7_6()
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
        DialogResult dr = MessageBox.Show("本当に購入しますか?", "確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

        if (dr == DialogResult.Yes)
        {
            MessageBox.Show("ご購入ありがとうございました", "購入",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }

}