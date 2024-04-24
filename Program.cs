namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number A:");
            int a = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Please enter number B:");
            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Numbers with exactly two 'A' symbols in their duodecimal representation between {a} and {b}:");

            int start = Math.Min(a, b);
            int end = Math.Max(a, b);

            for (int i = start; i <= end; i++)
            {
                string duodecimalRepresentation = ToDuodecimal(i);
                int countA = CountA(duodecimalRepresentation);
                if (countA == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static string ToDuodecimal(int number)
        {
            if (number == 0)
            {
                return "0";
            }

            bool isNegative = number < 0;
            number = Math.Abs(number);

            string result = "";

            while (number > 0)
            {
                int checkerNum = number % 12;
                if (checkerNum < 10)
                {
                    result = checkerNum + result;
                }
                else if (checkerNum == 10)
                {
                    result = "A" + result;
                }
                else if (checkerNum == 11)
                {
                    result = "B" + result;
                }
                number /= 12;
            }

            if (isNegative)
            {
                result = "-" + result;
            }

            return result;
        }

        public static int CountA(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == 'A')
                {
                    count++;
                }
            }
            return count;
        }
    }
}


