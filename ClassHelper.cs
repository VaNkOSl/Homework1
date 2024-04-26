namespace Homework;
public  class ClassHelper
{
   public  string ToDuodecimal(int number)
    {
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

        return result;
    }

   public  int CountA(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == 'A')
            {
                count++;
            }
        }
        return count;
    }
}

