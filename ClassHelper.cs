namespace Homework;
public class ClassHelper
{
    public int[] RemoveDuplicates(int[] array)
    {
        int n = array.Length;
        int[] uniqueArray = new int[n];
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            bool isDuplicated = false;

            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isDuplicated = true;
                    break;
                }
            }

            if (!isDuplicated)
            {
                uniqueArray[index++] = array[i];
            }
        }

        Array.Resize(ref uniqueArray, index);

        return uniqueArray;
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

