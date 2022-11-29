namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Welcome To Generics Problem ---------");


            int intArray = MaxNumberCheck<int>.MaxIntegerNumber(23, 42, 12);
            Console.WriteLine("\nMax integer number is: " + intArray);

            double output = MaxNumberCheck<double>.MaxIntegerNumber(33.2, 23.4, 12.5);
            Console.WriteLine("\nMax floating number is: " + output);

            char strArr = MaxNumberCheck<char>.MaxIntegerNumber('A', 'S', 'R');
            Console.WriteLine("\nMax string is: " + strArr);




        }
    }
}