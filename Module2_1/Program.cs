namespace Module2_1
{
    enum Figures { Romb, Rect, Square, Line }
    struct Fdata
    {
        public int x0, y0;
        public int color;
        public Figures type;


    }
    class Program
    {

        static void Main(string[] args)
        {
            Fdata fd = new Fdata() { x0 = 1, y0 = 1, color = 0x2727FF, type = Figures.Romb };
            Console.WriteLine($"type {fd.type}");
            Console.WriteLine($"location x = {fd.x0}, y = {fd.y0}");
            Console.WriteLine($"color {fd.color}");
        }
    }
}

