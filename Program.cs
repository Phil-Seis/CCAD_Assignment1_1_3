namespace CCAD_Assignment1_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to print the sum of two numbers.

            Console.WriteLine("Please type in two numbers below: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = Convert.ToDouble(num1 + num2);
            Console.WriteLine("The sum of your two numbers is: " + sum);
        }
    }
}
