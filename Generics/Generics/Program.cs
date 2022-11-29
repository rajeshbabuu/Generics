namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Welcome To Generics Problem ---------");


            int intArray = MaxNumberCheck.MaxIntegerNumber(23, 42, 12);
            Console.WriteLine("\nMax integer number is: " + intArray);

            double output = MaxNumberCheck.MaxIntegerNumber(33.2, 23.4, 12.5);
            Console.WriteLine("\nMax floating number is: " + output);

            string strArr = MaxNumberCheck.MaxIntegerNumber("Rajesh", "ViratKholi", "MSDhoni");
            Console.WriteLine("\nMax string is: " + strArr);




        }
    }
}