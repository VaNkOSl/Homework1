namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassHelper classHelper = new ClassHelper();

            Console.WriteLine("Enter the number of element array");
            int n = int.Parse(Console.ReadLine()!);
            if(n < 0)
            {
                Console.WriteLine("Numbers must be positive");
            }

            int[] originalArray = new int[n];

            Console.WriteLine("Enter the element of array");
            for (int i = 0; i < n; i++)
            {
                originalArray[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("Original Array:");
            classHelper.PrintArray(originalArray);


            int[] uniqueArray = classHelper.RemoveDuplicates(originalArray);
            Console.WriteLine("Unique Array");

            classHelper.PrintArray(uniqueArray);
        }
    }
}
