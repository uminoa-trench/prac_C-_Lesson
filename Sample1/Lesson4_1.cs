using System.Windows.Forms;
using System.Drawing;

class Lesson4_1
{

    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";


        Label lb = new Label();
        lb.Width = fm.Width; lb.Height = fm.Height;

        for (int i = 1; i <= 5; i++)
        {
            lb.Text += (i * 2) + "を表示します\n";
        }

        lb.Parent = fm;

        Application.Run(fm);

    }
}