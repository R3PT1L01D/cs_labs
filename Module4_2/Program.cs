using System.Text;

namespace Module4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToBinary(97));
        }

        static string IntToBinary(int value)
        {
            StringBuilder sb = new StringBuilder(Convert.ToString(value, 2));

            while (sb.Length < 32) sb.Insert(0, '0');

            for (int i = sb.Length; i > 0; i -= 8) sb.Insert(i, ' ');

            return sb.ToString();
        }
    }
}
