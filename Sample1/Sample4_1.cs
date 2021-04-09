using System.Windows.Forms;
using System.Drawing;

class Sample4_1
{

    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 300; fm.Height = 200;

        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("C:\\image\\image2.jpg");
        pb.Left = 150;

        Label lb = new Label();
        lb.Top = pb.Bottom;
        lb.Text = "空";

        /*if(pb.Left >= 150)
        {
            lb.Text = "空は東にあります";
        }
        else if(pb.Left <= 20)
        {
            lb.Text = "空は西に在ります";
        }
        else
        {
            lb.Text = "空は中部にあります";
        }
        
        switch (pb.Left)
        {
            case 20:
                lb.Text = "西の空";
                break;
            case 150:
                lb.Text = "東の空";
                break;
            default:
                lb.Text = "移動中";
                break;
        }
        */

        if(pb.Left >=0 && pb.Left <= fm.Width)
        {
            lb.Text = "空は画面内にあります";
        }
        else
        {
            lb.Text = "車は画面外にあります";
        }

        pb.Parent = fm;
        lb.Parent = fm;

        Application.Run(fm);

    }
}