using System.Windows.Forms;
using System.Xml;

class Sample10_4_1 :Form
{
    private TreeView tv;

    public static void Main()
    {
        Application.Run(new Sample10_4_1());
    }
    public Sample10_4_1()
    {
        this.Text = "サンプル";

        tv = new TreeView();
        tv.Dock = DockStyle.Fill;

        XmlDocument doc = new XmlDocument();
        doc.Load("C:\\image\\Sample.xml");

        XmlNode xmlroot = doc.DocumentElement;//ルートノードを取得
        TreeNode treeroot = new TreeNode();
        treeroot.Text = xmlroot.Name;//ルートノードをツリーのルートとする
        tv.Nodes.Add(treeroot);

        walk(xmlroot, treeroot);

        tv.Parent = this;
    }
    public static void walk(XmlNode xn, TreeNode tn)
    {
        for (XmlNode ch = xn.FirstChild; ch != null; ch = ch.NextSibling)//子ノードを順に処理
        {
            TreeNode n = new TreeNode();
            tn.Nodes.Add(n);
            walk(ch, n);//子ノードについて同じ処理をする
            if (ch.NodeType == XmlNodeType.Element)
            {
                n.Text = ch.Name;
            }
            else
            {
                n.Text = ch.Value;
            }
        }
    }

}