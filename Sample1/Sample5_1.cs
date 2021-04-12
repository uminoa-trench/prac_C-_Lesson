using System.Windows.Forms;
using System.Drawing;

class Sample5_1
{

    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 300; fm.Height = 200;

        PictureBox[] pb = new PictureBox[2];

        for (int i = 0; i < pb.Length; i++)
        {
            pb[i] = new PictureBox();
            pb[i].Parent = fm;
        }

        Car[] c = new Car[2];
        c[0] = new Car();
        c[1] = new RacingCar();

        for (int i = 0; i < c.Length; i++)
        {
            c[i].Move();
            pb[i].Image = c[i].GetImage();
            pb[i].Top = c[i].Top;
            pb[i].Left = c[i].Left;
        }

        /*
           Label lb = new Label();

           Car c1 = new Car();
           Car c2 = new Car();

           lb.Parent = fm;

           PictureBox pb = new PictureBox();

           Car c = new Car();
           c.Move();
           c.Move();

           pb.Image = c.GetImage();
           pb.Top = c.Top;
           pb.Left = c.Left;

           pb.Parent = fm;
       */

        Application.Run(fm);
        

    }

}

class Car
{
    //public static int Count = 0;//静的メンバ
    private Image img;
    protected int top;
    protected int left;

    public Car()
    {   //コンストラクタ

        //Count++;

        img = Image.FromFile("C:\\image\\image2.jpg");
        top = 0;
        left = 0;
    }

    /*
    public static string CountCar()
    {
        return "車は" + Count + "台あります";
    }
    */
  
    virtual public void Move()
    {
        top = top + 10;
        left = left + 10;
    }

    public void SetImage(Image i)
    {
        img = i;
    }

    public Image GetImage()
    {
        return img;
    }

    public int Top
    {
        set { top = value; }
        get { return top; }
    }

    public int Left
    {
        set { left = value; }
        get { return left; }
    }

}

class RacingCar : Car
{
    override public void Move()
    {
        top += 100;
        left += 100;
    }
}
        