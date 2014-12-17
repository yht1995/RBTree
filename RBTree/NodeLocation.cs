using System.Drawing;

namespace RBTree
{
    public class NodeLocation
    {
        private TypeRate rate;
        private Point certer;
        private int radius;

        public TypeRate Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public Point Certer
        {
            get { return certer; }
            set { certer = value; }
        }
        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public NodeLocation(TypeRate rate, Point center, int radius)
        {
            this.rate = rate;
            this.certer = center;
            this.radius = radius;
        }

        public bool InCircle(Point p)
        {
            int dx = p.X - certer.X;
            int dy = p.Y - certer.Y;
            if (dx * dx + dy * dy <= radius * radius)
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
