namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of element array");
            int n = int.Parse(Console.ReadLine()!);
            
            int[] originalArray = new int[n];

            Console.WriteLine("Enter the element of array");
            for (int i = 0; i < n; i++)
            {
                originalArray[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("Original Array:");
            PrintArray(originalArray);


            int[] uniqueArray = RemoveDuplicates(originalArray);
            Console.WriteLine("Unique Array");

            PrintArray(uniqueArray);
        }

     public static int[] RemoveDuplicates(int[] array)
    {
        int length = array.Length;

        if (length == 0 || length == 1)
        {
            return array;
        }

        int uniqueCount = 1;
        for (int i = 1; i < length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < uniqueCount; j++)
            {
                if (array[i] == array[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                array[uniqueCount] = array[i];
                uniqueCount++;
            }
        }

        Array.Resize(ref array, uniqueCount);
        return array;
    }

        public void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + "");
            }
            Console.WriteLine();
        }   
    }
}
