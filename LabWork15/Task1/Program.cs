namespace Task1
{
    internal class Program
    {

        public delegate int Function(int number);

        static void Main(string[] args)
        {
            Function func = Square;
            Console.WriteLine(func(10));

            func = Factorial;
            Console.WriteLine(func(6));

            func = Absolute;
            Console.WriteLine(func(-60));
        }

        public static int Square(int number) => number * number;

        public static int Factorial(int number) => (number < 0) ? -1 : (number < 2) ? 1 : number * Factorial(number - 1);

        public static int Absolute(int number) => (number < 0) ? (number * -1) : number;
    }
}
