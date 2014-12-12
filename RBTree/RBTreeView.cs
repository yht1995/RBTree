using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBTree
{
    public partial class RBTreeView : Form
    {
        private RBTree rbTree;
        private Graphics graphics;
        Random random = new Random();

        public RBTreeView()
        {
            InitializeComponent();
            rbTree = new RBTree();
            graphics = this.groupBoxRBTree.CreateGraphics();
            graphics.Clear(Color.WhiteSmoke);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student(Convert.ToInt32(textBoxScore.Text), textBoxID.Text, textBoxName.Text);
                graphics.Clear(Color.WhiteSmoke);
                if (!rbTree.Add(s))
                {
                    MessageBox.Show("插入失败");
                }
                if (rbTree.Head != null)
                {
                    DrawRBTree(rbTree.Head, new Point(350, 20), 150);
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("输入不合法");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student(Convert.ToInt32(textBoxScore.Text), textBoxID.Text, textBoxName.Text);
                graphics.Clear(Color.WhiteSmoke);
                if (!rbTree.Remove(s))
                {
                    MessageBox.Show("删除失败");
                }
                if (rbTree.Head != null)
                {
                    DrawRBTree(rbTree.Head, new Point(350, 20), 150);
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("输入不合法");
            }
        }

        private void DrawRBTree(Node node,Point p,int x)
        {
            if (node == null)
            {
                DrawNullNode(p);
                return;
            }
            Pen pen = new Pen(Color.Black,2);
            graphics.DrawLine(pen, new Point(p.X + 20, p.Y + 20), new Point(p.X - x + 20, p.Y + 80));
            graphics.DrawLine(pen, new Point(p.X + 20, p.Y + 20), new Point(p.X + x + 20, p.Y + 80));
            DrawNode(node,p);
            DrawRBTree(node.Left, new Point(p.X - x, p.Y + 60), x / 2);
            DrawRBTree(node.Right, new Point(p.X + x, p.Y + 60), x / 2);
        }

        private void DrawNode(Node n,Point p)
        {
            SolidBrush b1;
            if (n.IsRed)
            {
                b1 = new SolidBrush(Color.Red);
            }
            else
            {
                b1 = new SolidBrush(Color.Black);
            }
            graphics.FillEllipse(b1, p.X, p.Y, 40, 40);
            SolidBrush b2 = new SolidBrush(Color.White);
            graphics.DrawString(n.RateString(), new Font("Arial", 10), b2, p.X + 12, p.Y + 10);
            graphics.DrawString(n.StudentList.Count.ToString(), new Font("Arial", 10), b2, p.X + 12, p.Y + 20);

            b1.Dispose();
            b2.Dispose();
        }

        private void DrawNullNode(Point p)
        {
            SolidBrush b1 = new SolidBrush(Color.Black);
            graphics.FillEllipse(b1, p.X + 10, p.Y + 10, 20, 20);
            b1.Dispose();
        }

        private void buttonRand_Click(object sender, EventArgs e)
        {
            string[] nameA = new string[] { "蚌", "赵", "李", "孟", "雷", "劳" ,"王"};
            string[] nameB = new string[] { "绍", "夕", "宛", "岳", "磊", "维" ,"勇"};
            string[] nameC = new string[] { "诗", "炜", "洲", "", "", "旻" ,""};

            textBoxName.Text = nameA[random.Next(0, nameA.Count() - 1)]
                + nameB[random.Next(0, nameB.Count() - 1)]
                + nameC[random.Next(0, nameC.Count() - 1)];

            textBoxID.Text = random.Next(20149999).ToString();
            textBoxScore.Text = random.Next(100).ToString();
        }
    }
}
