using System;

namespace ExtensionMethodDemo
{
    public static class ExtMethodClass
    {
        public static string ToCurrency(this string str)
        {
            if (str.ToCharArray().All(char.IsDigit))
                return string.Format("${0}", str);
            else
                throw new ArgumentException("Entered String does not contain numbers", str);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string given = Console.ReadLine();
            string result = ExtMethodClass.ToCurrency(given);
            Console.WriteLine(result);
        }
    }
}   
