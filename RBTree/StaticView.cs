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
    public partial class StaticView : Form
    {
        private int count;
        private double average;
        private int min;
        private int max;
        private double variance;
        List<Student> list;

        public StaticView()
        {
            InitializeComponent();
        }

        public void InputData(List<Student> list)
        {
            this.list = list;
            count = list.Count;
            textBoxCount.Text = count.ToString();
            average = CalcAverage();
            textBoxAverage.Text = average.ToString();
            min = CalcMin();
            max = CalcMax();
            variance = CalcVariance();
            textBoxMin.Text = min.ToString();
            textBoxMax.Text = max.ToString();
            textBoxVariance.Text = variance.ToString();
        }

        private double CalcAverage()
        {
            int sum = 0;
            foreach (Student s in list)
            {
                sum += s.Socre;
            }
            return (sum / count);
        }

        private int CalcMax()
        {
            int max = 0;
            foreach (Student s in list)
            {
                if (s.Socre > max)
                {
                    max = s.Socre;
                }
            }
            return max;
        }

        private int CalcMin()
        {
            int min = 100;
            foreach (Student s in list)
            {
                if (s.Socre < min)
                {
                    min = s.Socre;
                }
            }
            return min;
        }

        private double CalcVariance()
        {
            double diff = 0;
            foreach (Student s in list)
            {
                diff += Math.Pow((s.Socre - average), 2);
            }
            return (diff / count);
        }

    }
}
