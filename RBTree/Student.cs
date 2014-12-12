using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTree
{
    public enum Rate
    {
        AAplus = 9,
        AA = 8,
        A = 7,
        Bplus = 6,
        B = 5,
        Bminus = 4,
        Cplus = 3,
        C = 2,
        D = 1,
        E = 0
    }

    public class Student
    {
        private Rate rate;
        private int socre;
        private string id;
        private string name;

        public Student(int socre, string id, string name)
        {
            if (socre >= 95 && socre <= 100)
            {
                rate = Rate.AAplus;
            }
            else if (socre >= 90)
            {
                rate = Rate.AA;
            }
            else if (socre >= 85)
            {
                rate = Rate.A;
            }
            else if (socre >= 80)
            {
                rate = Rate.Bplus;
            }
            else if (socre >= 75)
            {
                rate = Rate.B;
            }
            else if (socre >= 70)
            {
                rate = Rate.Bminus;
            }
            else if (socre >= 65)
            {
                rate = Rate.Cplus;
            }
            else if (socre >= 60)
            {
                rate = Rate.C;
            }
            else if (socre >= 50)
            {
                rate = Rate.D;
            }
            else
            {
                rate = Rate.E;
            }

            this.socre = socre;
            this.id = id;
            this.name = name;
        }

        public Rate Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public int Socre
        {
            get { return socre; }
            set { socre = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static bool operator <(Student a, Student b)
        {
            if (a.Rate < b.Rate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Student a, Student b)
        {
            if (a.Rate > b.Rate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
