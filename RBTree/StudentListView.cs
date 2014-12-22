using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBTree
{
    public partial class StudentListView : Form
    {
        private Student selected;
        private List<Student> list = new List<Student>();
        public Student Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        public StudentListView()
        {
            InitializeComponent();
            InitListView(listView);
        }

        public void AddStudent(Student s)
        {
            ListViewItem item = new ListViewItem();
            item.Text = s.Name;
            item.SubItems.Add(s.ID);
            item.SubItems.Add(s.Socre.ToString());
            this.listView.Items.Add(item);
            textBoxNum.Text = listView.Items.Count.ToString();
        }

        public void AddStudent(List<Student> list)
        {
            foreach (Student s in list)
            {
                this.list.Add(s);
                ListViewItem item = new ListViewItem();
                item.Text = s.Name;
                item.SubItems.Add(s.ID);
                item.SubItems.Add(s.Socre.ToString());
                this.listView.Items.Add(item);
            }
            textBoxNum.Text = listView.Items.Count.ToString();
        }

        private void InitListView(ListView ListView)
        {
            ColumnHeader col1 = new ColumnHeader();
            col1.Width = 100;
            col1.Text = "姓名";
            listView.Columns.Add(col1);
            ColumnHeader col2 = new ColumnHeader();
            col2.Width = 100;
            col2.Text = "学号";
            listView.Columns.Add(col2);
            ColumnHeader col3 = new ColumnHeader();
            col3.Width = 50;
            col3.Text = "成绩";
            listView.Columns.Add(col3);
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selected = list[listView.SelectedItems[0].Index];
        }
    }
}
