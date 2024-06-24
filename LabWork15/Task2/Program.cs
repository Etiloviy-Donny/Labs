namespace Task2
{
    internal class Program
    {
        public delegate void Calc(int number1, int number2);

        static void Main(string[] args)
        {
            Calc func = new Calc(Sum);
            func += Sub;
            func += Multipl;
            func += Div;
            func?.Invoke(10, 4);
        }

        public static void Sum(int number1, int number2) => Console.WriteLine($"Сумма чисел {number1 + number2}");

        public static void Sub(int number1, int number2) => Console.WriteLine($"Разность чисел {number1 - number2}");

        public static void Multipl(int number1, int number2) => Console.WriteLine($"Произведение чисел {number1 * number2}");

        public static void Div(int number1, int number2) => Console.WriteLine($"Частное чисел {number1 / number2}");

    }
}
