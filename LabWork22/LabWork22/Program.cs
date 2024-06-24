namespace Task1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Run(() => PowerCalculator(1.1, 2));
            await Task.Run(() => PowerCalculator(2, 8));
            await Task.Run(() => PowerCalculator(3, 7));

            await Task.WhenAll(
                Task.Run(() => PowerCalculator(4, 6)),
                Task.Run(() => PowerCalculator(5, 5)),
                Task.Run(() => PowerCalculator(6, -4))
                );
        }
        static void PowerCalculator(double a, int x)
        {
            double result = 1;
            if (x > 0)
            {
                for (int i = 0; i < x; i++)
                {
                    result *= a;
                }
                Console.WriteLine($"{a}^{x}={result}");
            }
            if (x < 0)
            {
                for (int i = 0; i > x; i--)
                {
                    result *= a;
                }
                Console.WriteLine($"{a}^{x}={1 / result}");
            }
        }
    }
}
