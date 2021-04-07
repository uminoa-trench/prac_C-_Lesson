using System.Drawing;
using System.Windows.Forms;

class Sample3_2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";

        int w;
        w = 100;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("C:\\image\\image2.jpg");
        pb.Top = w;

        pb.Parent = fm;

        Application.Run(fm);
    }
}