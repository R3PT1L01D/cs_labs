using System;

namespace Module3_2
{
    enum Figures { Romb, Rect, RightTriangle, Circle }
    struct Fdata
    {
        public int x0, y0;
        public double a, b;

        // предположим, что:
        // 1. b для Figures.Romb — высота, приведенная к стороне a
        // 2. a для Figures.Cirlce радиус, a b не исользуется (или хранит длину окружности)
        // 3. a и b для Figures.Rect длины сторон
        // UPD: посмотрел в ответах, там для каждой фигуры определяются специфические измерения, но задании явно не определено, какие измерения для какого типа фигуры используются, по этому формулы вычисления площади решил не менять.

        public int color;
        public Figures type;
    }
    class Program
    {

        static void Main(string[] args)
        {
            Fdata fd = new Fdata() { a = 4.1, b = 3, type = Figures.Romb };
            Console.WriteLine(area(fd));
            Console.WriteLine("Ok");
        }

        static double area(Fdata fd)
        {
            switch (fd.type)
                {
                case Figures.Circle:            return fd.a * fd.a * Math.PI;
                case Figures.RightTriangle:     return Math.Sqrt(3) / 4.0 * fd.a * fd.a;
                default:                        return fd.a * fd.b;
                    

                };
        }
    }
}
