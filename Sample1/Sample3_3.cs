﻿using System.Drawing;
using System.Windows.Forms;

class Sample3_3
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";


        PictureBox pb = new PictureBox();
        pb.Image = Image.FromFile("C:\\image\\image2.jpg");
        pb.Top = (fm.Height - pb.Height) / 2;
        pb.Left = (fm.Width - pb.Width) / 2;

        pb.Parent = fm;

        Application.Run(fm);
    }
}