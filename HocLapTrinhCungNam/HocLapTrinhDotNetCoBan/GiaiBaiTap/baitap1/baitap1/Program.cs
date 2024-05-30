namespace baitap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Nhập vào 5 số nguyên:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Số thứ {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"Số lớn nhất là: {max}");
        }
    }
}
