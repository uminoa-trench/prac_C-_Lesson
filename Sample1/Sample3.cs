using System.Windows.Forms;

class Sample3
{
    public static void Main()
    {
        Form fm;
        fm = new Form();

        fm.Text = "ようこそC#へ";

        Label lb = new Label(); //ラベルを作成
        lb.Text = "C#をはじめよう"; //ラベルのタイトル設定
        lb.Parent = fm; // ラベルをフォームに設定

        Application.Run(fm);
    }
}