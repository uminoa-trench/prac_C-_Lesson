using System.Windows.Forms;
using System.Drawing;

class Sample4_3
{

    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 250; fm.Height = 100;

        /*
        PictureBox[] pb = new PictureBox[5];

        for(int i = 0; i < pb.Length; i++)
        {
            pb[i] = new PictureBox();
            pb[i].Image = Image.FromFile("C:\\image\\image2.jpg");
            pb[i].Top = i * pb[i].Height;
            pb[i].Parent = fm;
        }
        */

        Label lb = new Label();
        lb.Width = fm.Width; lb.Height = fm.Height;

        string[] str = new string[3] { "鉛筆", "消しゴム", "定規" };

        foreach(string s in str)
        {
            lb.Text += s + "\n";
        }

        lb.Parent = fm;

        Application.Run(fm);

    }
}