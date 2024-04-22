namespace Homework
{
    internal class Program
    {


        static void Main(string[] args)
        {
            ClassHelper helper = new ClassHelper();

            Console.WriteLine("Please enter number A:");
            int a = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Please enter number B:");
            int b = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Numbers with exactly two 'A' symbols in their duodecimal representation between {a} and {b}:");

            for (int i = a; i <= b; i++)
            {
                string duodecimalRepresentation = helper.ToDuodecimal(i);
                int countA = helper.CountA(duodecimalRepresentation);
                if (countA == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

