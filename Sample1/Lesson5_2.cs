using System.Windows.Forms;
using System.Drawing;

class Lesson5_2
{
    public static void Main()
    {

        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 300; fm.Height = 200;

        WhiteLabel[] wl = new WhiteLabel[2];
        wl[0] = new WhiteLabel();
        wl[1] = new WhiteLabel();

        wl[0].Text = "こんにちは";
        wl[1].Text = "さようなら";

        wl[1].Left = wl[1].Width + 10;

        wl[0].Parent = fm;
        wl[1].Parent = fm;

        Application.Run(fm);
    }
}

class WhiteLabel : Label
{
    public WhiteLabel()
    {
        this.BackColor = Color.White;
    }

}