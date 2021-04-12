using System;
using System.Windows.Forms;

class Sample7_1 : Form
{
    private Button[] bt = new Button[6];
    //private FlowLayoutPanel flp;//直線的に並べる
    private TableLayoutPanel tlp;

    public static void Main()
    {
        Application.Run(new Sample7_1());
    }

    public Sample7_1()
    {
        this.Text = "サンプル";
        this.Width = 600; this.Height = 100;

        //flp = new FlowLayoutPanel();//
        //flp.Dock = DockStyle.Fill;

        tlp = new TableLayoutPanel();
        tlp.Dock = DockStyle.Fill;

        //3×2に並べる
        tlp.ColumnCount = 3;//横に並べる数
        tlp.RowCount = 2;//縦に並べる数

        for (int i = 0; i < bt.Length; i++)//ボタンを直線的に並べる
        {
            //ボタンを直線的に並べる
            /*
            bt[i] = new Button();
            bt[i].Text = Convert.ToString(i);
            bt[i].Parent = flp;
            */

            //ボタンを格子状に並べる
            bt[i] = new Button();
            bt[i].Text = Convert.ToString(i);
            bt[i].Parent = tlp;


        }

        //flp.Parent = this;
        tlp.Parent = this;

    }
}