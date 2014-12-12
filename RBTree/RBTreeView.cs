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
        GraphicsState blank;
        public RBTreeView()
        {
            InitializeComponent();
            rbTree = new RBTree();
            graphics = this.groupBoxRBTree.CreateGraphics();
            blank = graphics.Save();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student(Convert.ToInt32(textBoxScore.Text), textBoxID.Text, textBoxName.Text);
            rbTree.Add(s);
            graphics.Restore(blank);
            Point p = new Point(350,40);
            DrawRBTree(rbTree.Head,p,150);
        }

        private void DrawRBTree(Node node,Point p,int x)
        {
            if (node == null)
            {
                DrawNullNode(p);
                return;
            }
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
            graphics.DrawString(n.RateString(), new Font("宋体", 10), b2, p.X + 12, p.Y +10);
            graphics.DrawString(n.StudentList.Count.ToString(), new Font("宋体", 10), b2, p.X +12, p.Y + 20);

            b1.Dispose();
            b2.Dispose();
        }

        private void DrawNullNode(Point p)
        {
            SolidBrush b1 = new SolidBrush(Color.Black);
            graphics.FillEllipse(b1, p.X + 10, p.Y, 20, 20);
            b1.Dispose();
        }
    }
}
