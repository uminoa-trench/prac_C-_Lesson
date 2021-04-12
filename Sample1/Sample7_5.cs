using System;
using System.Windows.Forms;

class Sample7_5 : Form
{
    private Label lb;
    private MenuStrip ms;
    private ToolStripMenuItem[] ml
                      = new ToolStripMenuItem[10];

    public static void Main()
    {
        Application.Run(new Sample7_5());
    }

    public Sample7_5()
    {
        this.Text = "サンプル";
        this.Width = 250; this.Height = 200;

        lb = new Label();
        lb.Text = "いらっしゃいませ";
        lb.Dock = DockStyle.Bottom;

        ms = new MenuStrip();
        ml[0] = new ToolStripMenuItem("メイン1");
        ml[1] = new ToolStripMenuItem("メイン2");
        ml[2] = new ToolStripMenuItem("サブ1");
        ml[3] = new ToolStripMenuItem("サブ2");
        ml[4] = new ToolStripMenuItem("乗用車");
        ml[5] = new ToolStripMenuItem("トラック");
        ml[6] = new ToolStripMenuItem("オープンカー");
        ml[7] = new ToolStripMenuItem("タクシー");
        ml[8] = new ToolStripMenuItem("スポーツカー");
        ml[9] = new ToolStripMenuItem("ミニカー");

        ml[0].DropDownItems.Add(ml[4]);
        ml[0].DropDownItems.Add(ml[5]);

        ml[1].DropDownItems.Add(ml[2]);
        ml[1].DropDownItems.Add(new ToolStripSeparator());
        ml[1].DropDownItems.Add(ml[3]);
        ml[2].DropDownItems.Add(ml[6]);
        ml[2].DropDownItems.Add(ml[7]);
        ml[3].DropDownItems.Add(ml[8]);
        ml[3].DropDownItems.Add(ml[9]);

        ms.Items.Add(ml[0]);
        ms.Items.Add(ml[1]);

        this.MainMenuStrip = ms;

        ms.Parent = this;
        lb.Parent = this;

        for (int i = 0; i < ml.Length; i++)
        {
            ml[i].Click += new EventHandler(ml_Click);
        }

    }

    public void ml_Click(Object sender, EventArgs e)
    {
        ToolStripMenuItem mi = (ToolStripMenuItem)sender;
        lb.Text = mi.Text + "ですね";
    }
}