namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Welcome To Generics Problem ---------");


            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'S', 'E', 'L', 'L', 'O' };

            GenericsProgram.toPrint(intArray);
            GenericsProgram.toPrint(doubleArray);
            GenericsProgram.toPrint(charArray);
        }
    }
}