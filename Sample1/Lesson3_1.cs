using System.Drawing;
using System.Windows.Forms;

class Lesson3_1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Height = 200;
        fm.Width = 300;

        Label lb = new Label();
        lb.Text = "こんにちは";
        lb.Top = (fm.Height / 2) - (lb.Height / 2) ;
        lb.Left = (fm.Width / 2) - (lb.Width / 2) ;
        lb.Parent = fm;

        Application.Run(fm);
    }
}