namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Input the first 9 digits of the ISBN: ");
             string input = Console.ReadLine()!;
            
             string isbn = input + CalculateCheckDigit(input);
             Console.WriteLine("ISBN-10: " + isbn);
        }

      public static string CalculateCheckDigit(string input)
      {
          int[] digits = new int[input.Length];
          for (int i = digits.Length - 1; i >= 0; i--)
          {
              digits[i] = int.Parse(input[i].ToString());
          }

          int sum = 0;
          for (int i = 0; i < digits.Length; i++)
          {
              sum += (i + 2) * digits[digits.Length - 1 - i];
          }

          int checkDigit = (11 - (sum % 11)) % 11;

          return checkDigit == 10 ? "X" : checkDigit.ToString();
      }
    }
}
