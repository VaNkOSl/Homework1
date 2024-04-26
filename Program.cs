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
           Dictionary<int, bool> seen = new Dictionary<int, bool>();
           List<int> uniqueList = new List<int>();

           foreach (int num in array)
           {
               if (!seen.ContainsKey(num))
               {
                   uniqueList.Add(num);
                   seen[num] = true;
               }
           }

           return uniqueList.ToArray();
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
