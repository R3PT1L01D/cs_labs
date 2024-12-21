namespace Module4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.Write(arg);
            }
            Console.WriteLine();

            int sum = 0;
            int a;

            foreach (var s in args)
            {
                if (int.TryParse(s, out a)) sum += a;
            }
            Console.WriteLine(sum);
             
        }
    }
}
