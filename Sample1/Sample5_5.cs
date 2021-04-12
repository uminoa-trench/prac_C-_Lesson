using System.Windows.Forms;
using System.Drawing;

class Sample5_5 : Form
{
    public static void Main()
    {
        Application.Run(new Sample5_5());
    }

    public Sample5_5()
    {
        this.Text = "サンプル";
        this.Width = 400; this.Height = 200;
        this.BackgroundImage = Image.FromFile("C:\\image\\image2.jpg");
    }
}