namespace Homework;
public class ClassHelper
{
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

