using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace RBTree
{
    public partial class RBTreeView : Form
    {
        private RBTree rbTree;
        private Graphics graphics;
        Random random = new Random();
        private HashTable<Student> hashID;
        private HashTable<Student> hashName;
        private List<NodeLocation> nodeTable = new List<NodeLocation>();

        public RBTreeView()
        {
            InitializeComponent();
            rbTree = new RBTree();
            hashID = new HashTable<Student>(1000,
                delegate(Student s)
                {
                    return (s.ID.GetHashCode());
                },
                delegate(Student a, Student b)
                {
                    return (a.ID == b.ID);
                });
            hashName = new HashTable<Student>(1000,
                delegate(Student s)
                {
                    return (s.Name.GetHashCode());
                },
                delegate(Student a,Student b)
                {
                    return(a.Name == b.Name);
                });
            graphics = this.CreateGraphics();
            graphics.Clear(Color.WhiteSmoke);
            for (int i = 0; i <= 9;i++)
            {
                TypeRate type = (TypeRate)i;
                string s;
                switch (type)
                {
                    case (TypeRate.AAplus):
                        s = "AA+";
                        break;
                    case (TypeRate.Bplus):
                        s = "B+";
                        break;
                    case (TypeRate.Bminus):
                        s = "B-";
                        break;
                    case (TypeRate.Cplus):
                        s = "C+";
                        break;
                    default:
                        s = type.ToString();
                        break;
                }
                comboBoxRateS.Items.Add(s);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student(Convert.ToInt32(textBoxScore.Text), textBoxID.Text, textBoxName.Text);
                rbTree.Add(s);
                hashID.Add(s);
                hashName.Add(s);
                DoubleBufDraw();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student(Convert.ToInt32(textBoxScore.Text), textBoxID.Text, textBoxName.Text);
                rbTree.Remove(s);
                hashID.Remove(s);
                hashID.Remove(s);
                DoubleBufDraw();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoubleBufDraw()
        {
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
            BufferedGraphics myBuffer = currentContext.Allocate(graphics,new Rectangle(0,0,800,600));
            Graphics g = myBuffer.Graphics;
            g.Clear(Color.WhiteSmoke);
            if (rbTree.Head != null)
            {
                nodeTable.Clear();
                DrawRBTree(g,rbTree.Head, new Point(350, 20), 150);
            }
            myBuffer.Render(graphics);
            myBuffer.Dispose();
            g.Dispose();  
        }

        private void DrawRBTree(Graphics graphics,Node node,Point p,int x)
        {
            if (node == null)
            {
                DrawNullNode(graphics,p);
                return;
            }
            Pen pen = new Pen(Color.Black,2);
            graphics.DrawLine(pen, new Point(p.X + 20, p.Y + 20), new Point(p.X - x + 20, p.Y + 80));
            graphics.DrawLine(pen, new Point(p.X + 20, p.Y + 20), new Point(p.X + x + 20, p.Y + 80));
            DrawNode(graphics,node, p);
            DrawRBTree(graphics,node.Left, new Point(p.X - x, p.Y + 60), x / 2);
            DrawRBTree(graphics,node.Right, new Point(p.X + x, p.Y + 60), x / 2);
        }

        private void DrawNode(Graphics graphics, Node n, Point p)
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
            graphics.DrawString(n.RateString(), new Font("Arial", 10), b2, p.X + 12, p.Y + 8);
            graphics.DrawString(n.StudentList.Count.ToString(), new Font("Arial", 10), b2, p.X + 12, p.Y + 22);
            b1.Dispose();
            b2.Dispose();
            nodeTable.Add(new NodeLocation(n.Key, new Point(p.X + 20,p.Y + 20), 20));
        }

        private void DrawNullNode(Graphics graphics, Point p)
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

        private void buttonImport_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "文本文件(*.txt)|*.txt";
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rbTree = new RBTree();
                string FileName = this.openFileDialog.FileName;
                StreamReader sr = new StreamReader(FileName,Encoding.Default);
                while (!sr.EndOfStream)
                {
                    string strContent = sr.ReadLine();
                    string[] str = new string[3];
                    str = strContent.Split(' ');
                    Student s = new Student(Convert.ToInt32(str[2]), str[1], str[0]);
                    rbTree.Add(s);
                    hashID.Add(s);
                    hashName.Add(s);
                }
                sr.Close();
                DoubleBufDraw();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.Filter = "文本文件(*.txt)|*.txt";
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = this.saveFileDialog.FileName;
                StreamWriter sr = new StreamWriter(FileName, false, Encoding.Default);
                if (rbTree.Head != null)
                {
                    InorderWrite(rbTree.Head, sr);
                }
                sr.Flush();
                sr.Close();
            }
        }

        private void InorderWrite(Node node, StreamWriter s)
        {
            if (node == null)
            {
                return;
            }
            InorderWrite(node.Left,s);
            foreach (Student stu in node.StudentList)
            {
                s.WriteLine(stu.Name + " " + stu.ID + " " + stu.Socre.ToString());
            }
            InorderWrite(node.Right,s);
        }

        private void buttonInorderTraversal_Click(object sender, EventArgs e)
        {
            StudentListView list = new StudentListView();
            list.Text = "中序遍历";
            if (rbTree.Head != null)
            {
                InorderTraversal(rbTree.Head,list);
            }
            list.ShowDialog();
        }
        
        private void InorderTraversal(Node node, StudentListView s)
        {
            if (node == null)
            {
                return;
            }
            InorderTraversal(node.Left, s);
            foreach (Student stu in node.StudentList)
            {
                s.AddStudent(stu);
            }
            InorderTraversal(node.Right, s);
        }

        private void buttonLevelTraversal_Click(object sender, EventArgs e)
        {
            StudentListView list = new StudentListView();
            list.Text = "层次遍历";
            if (rbTree.Head != null)
            {
                LevelTraversal(rbTree.Head, list);
            }
            list.ShowDialog();
        }

        private void LevelTraversal(Node node, StudentListView s)
        {
            Queue<Node> qNode = new Queue<Node>();
            qNode.Enqueue(node);
            while (qNode.Count != 0)
            {
                Node top = qNode.Dequeue();
                if (top.Left != null)
                {
                    qNode.Enqueue(top.Left);
                }
                if (top.Right != null)
                {
                    qNode.Enqueue(top.Right);
                }
                foreach (Student stu in top.StudentList)
                {
                    s.AddStudent(stu);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            #region ID 
            if (radioButtonID.Checked)
            {
                List<Student> list = hashID.Find(new Student(0,textBoxIDS.Text,""));
                if (list.Count != 0)
                {
                    StudentListView listView = new StudentListView();
                    listView.Text = "按学号查找";
                    listView.AddStudent(list);
                    listView.ShowDialog();
                }
                else
                {
                    MessageBox.Show("没有找到！");
                }
            }
            #endregion
            #region Name
            else if (radioButtonName.Checked)
            {
                List<Student> list = hashName.Find(new Student(0, "", textBoxNameS.Text));
                if (list.Count != 0)
                {
                    StudentListView listView = new StudentListView();
                    listView.Text = "按姓名查找";
                    listView.AddStudent(list);
                    listView.ShowDialog();
                }
                else
                {
                    MessageBox.Show("没有找到！");
                }
            }
            #endregion
            #region Rate
            else if (radioButtonRate.Checked)
            {
                TypeRate rate = (TypeRate)comboBoxRateS.SelectedIndex;
                List<Student> list = rbTree.FindInRate(rate);
                if (list.Count != 0)
                {
                    StudentListView listView = new StudentListView();
                    listView.Text = "按成绩段查找";
                    listView.AddStudent(list);
                    listView.ShowDialog();
                }
                else
                {
                    MessageBox.Show("没有找到！");
                }
            }
            #endregion
            #region Score
            else if (radioButtonScore.Checked)
            {
                int min = Convert.ToInt32(textBoxScoreL.Text);
                int max = Convert.ToInt32(textBoxScoreH.Text);
                if (min < 0 || max > 100 || min > max)
                {
                    MessageBox.Show("输入不合法");
                }
                else
                {
                    TypeRate rate = (TypeRate)comboBoxRateS.SelectedIndex;
                    List<Student> list = rbTree.FindInScore(min, max);
                    if (list.Count != 0)
                    {
                        StudentListView listView = new StudentListView();
                        listView.Text = "按分数段查找";
                        listView.AddStudent(list);
                        listView.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("没有找到！");
                    }
                }
            }
            #endregion
        }

        private void RBTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (NodeLocation l in nodeTable)
            {
                if (l.InCircle(e.Location))
                {
                    List<Student> list = rbTree.FindInRate(l.Rate);
                    if (list.Count != 0)
                    {
                        StudentListView listView = new StudentListView();
                        listView.Text = "节点明细";
                        listView.AddStudent(list);
                        listView.ShowDialog();
                    }
                }
            }
        }
    }
}
