namespace Module3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //max input for long is 20
            Console.WriteLine(ffactorial(0));
            Console.WriteLine(rfactorial(20));
        }

        static long ffactorial(int n)
        {
            if (n == 0) return 1;

            long res = 1;               
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        static long rfactorial(int n)
        {
            if (n == 0) return 1;

            return n < 1 ? 1 : n * rfactorial(n - 1);
        }

    }

    
}
