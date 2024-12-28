using System;

namespace Module5_1
{
    public enum Figures { Romb, Rect, RightTriangle, Circle }

    public struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(new Fdata() { x0 = 1, y0 = 1, a = 3, b = 5 });
            rect.Move(2, 1);
            rect.PrintInfo();
            Console.WriteLine(rect.Area());

            RightTriangle rt = new RightTriangle(new Fdata() { x0 = -1, y0 = -3, a = 1, b = 4 });
            rt.Move(1, 1);
            rt.PrintInfo();
            Console.WriteLine(rt.Area());

            Circle circle = new Circle(new Fdata() { x0 = -1, y0 = -3, a = 1});
            circle.Move(1, 1);
            circle.PrintInfo();
            Console.WriteLine(circle.Area());

            Console.WriteLine();
            object[] data = { rect, rt, circle };
            Print(data);
        }

        public static void Print(object[] data)
        {
            //не понял приведения типов в варианте решения в ответах, да и в условии задания не запрещено менять код ругих классов
            //зато в этом задании я понял, насколько важно наследование: вместо того, чтобы создавать спагетти из трех классов посредством почти полного копирования, можно было реализовать класс Figure и наследников
            foreach (object obj in data) Console.WriteLine(obj.ToString());
        }
    }
}
