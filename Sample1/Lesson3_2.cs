using System.Drawing;
using System.Windows.Forms;

class Lesson3_2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Height = 200;
        fm.Width = 300;

        Label lb = new Label();
        lb.Text = "こんにちは";
        lb.Parent = fm;

        Label lb1 = new Label();
        lb1.Text = "さようなら";
        lb1.Left = lb.Width + 100;
        lb1.Parent = fm;

        Application.Run(fm);
    }
}