using System.Drawing;
using System.Windows.Forms;

class Sample4
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("C:\\image\\image2.jpg");
        pb.Parent = fm;

        Application.Run(fm);
    }
}