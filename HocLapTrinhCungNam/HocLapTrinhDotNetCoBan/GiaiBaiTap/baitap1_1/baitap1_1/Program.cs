namespace baitap1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int max = int.MinValue;

            Console.Write("So 1: ");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.Write("So 2: ");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.Write("So 3: ");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.Write("So 4: ");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.Write("So 5: ");
            n = int.Parse(Console.ReadLine());
            if (n > max)
            {
                max = n;
            }

            Console.WriteLine("So lon nhat la: " + max.ToString());
        }
    }
}
