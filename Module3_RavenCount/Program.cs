namespace Module3_RavenCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество ворон на ветке");
            int a = int.Parse(Console.ReadLine());

            string str;
            if (a % 100 > 10 && a % 100 < 15) str = "ворон";
            else
                switch (a % 10)
                {
                    case 1: str = "ворона"; break;
                    case 2:
                    case 3:
                    case 4:str = "вороны"; break;
                    default: str = "ворон"; break;
                }

            Console.Write($"на ветке {a} {str}");

        }
    }
}
