namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first 9 digits of the ISBN: ");
            string userInput = Console.ReadLine()!;

            int checkDigit = CalculateCheckDigit(userInput);

            string result;
            if (checkDigit == 10)
            {
                result = "X";
            }
            else
            {
                result = checkDigit.ToString();
            }

            Console.WriteLine("The result ISBN is: " + userInput + result);
        }

        private static int CalculateCheckDigit(string isbnDigits)
        {
            int sum = 0;
            for (int i = 0; i < isbnDigits.Length; i++)
            {
                int digit = int.Parse(isbnDigits[i].ToString());
                sum += digit * (i + 1);
            }

            int checkDigit = sum % 11;

            if (checkDigit == 10 )
            {
                return checkDigit;
            }
            else
            {
                return checkDigit;
            }
        }
    }
}
