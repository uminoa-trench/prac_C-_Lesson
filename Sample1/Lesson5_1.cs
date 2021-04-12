using System.Windows.Forms;
using System.Drawing;

class Lesson5_1
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 300; fm.Height = 200;

        Ball ball = new Ball();
        ball.Move();

        Label lb = new Label();
        lb.Text = "ボールの位置は\nTop:" + ball.Top + "Left:" + ball.Left + "です。";
        lb.Parent = fm;

        Application.Run(fm);

    }
}

class Ball
{
    private int top;
    private int left;

    public Ball()
    {
        top = 0;
        left = 0;
    }

    
    public void Move()
    {
        top += 10;
        left += 10;
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