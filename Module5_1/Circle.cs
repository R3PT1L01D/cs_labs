using System;

namespace Module5_1
{
    class Circle
    {
        Fdata fd;

        public double a
        {
            get { return fd.a; }
            set { fd.a = value; }
        }

        public Circle(Fdata fd)
        {
            this.fd = fd;
            this.fd.type = Figures.Circle;
        }

        public double Area()
        {
            return Math.PI * a * a;
        }
        public void Move(int dx, int dy)
        {
            fd.x0 += dx;
            fd.y0 += dy;
        }
        public void PrintInfo()
        {
            //Console.Write(fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color);
            //Console.WriteLine(" a=" + a);
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return (fd.type + ":" + fd.x0 + "," + fd.y0 + " color=" + fd.color + " a=" + a);
        }
    }
}