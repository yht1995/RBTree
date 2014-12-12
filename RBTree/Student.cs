using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBTree
{
    public enum TypeRate
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
        private TypeRate rate;
        private int score;
        private string id;
        private string name;

        public Student(int score, string id, string name)
        {
            if (score >= 95 && score <= 100)
            {
                rate = TypeRate.AAplus;
            }
            else if (score >= 90)
            {
                rate = TypeRate.AA;
            }
            else if (score >= 85)
            {
                rate = TypeRate.A;
            }
            else if (score >= 80)
            {
                rate = TypeRate.Bplus;
            }
            else if (score >= 75)
            {
                rate = TypeRate.B;
            }
            else if (score >= 70)
            {
                rate = TypeRate.Bminus;
            }
            else if (score >= 65)
            {
                rate = TypeRate.Cplus;
            }
            else if (score >= 60)
            {
                rate = TypeRate.C;
            }
            else if (score >= 50)
            {
                rate = TypeRate.D;
            }
            else
            {
                rate = TypeRate.E;
            }

            this.score = score;
            this.id = id;
            this.name = name;
        }

        public TypeRate Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public int Socre
        {
            get { return score; }
            set { score = value; }
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
