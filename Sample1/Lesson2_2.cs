using System.Windows.Forms;

class Lesson2_2
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";

        Label lb = new Label(); //ラベルを作成
        lb.Text = "また会いましょう!"; //ラベルのタイトル設定
        lb.Parent = fm; // ラベルをフォームに設定

        Application.Run(fm);
    }
}