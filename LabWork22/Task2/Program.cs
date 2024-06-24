namespace Task2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await Task.WhenAll(
                Task.Run(() => PowerCalculator(4, 6)),
                Task.Run(() => PowerCalculator(5, 5)),
                Task.Run(() => PowerCalculator(6, -4))
                );
        }

        static async void GetPowerAsync(double a1, double a2, double a3, double a4, int x1, int x2, int x3, int x4)
        {
            (PowerCalculator(a1, x1) + PowerCalculator(a2, x2)) / (PowerCalculator(a3, x3) - PowerCalculator(a4, x4));
        }

        static double PowerCalculator(double a, int x)
        {
            double result = 1;
            if (x > 0)
            {
                for (int i = 0; i < x; i++)
                {
                    result *= a;
                }
            }
            if (x < 0)
            {
                for (int i = 0; i > x; i--)
                {
                    result *= a;
                    return 1 / result;
                }
            }
            return result;
        }
    }
}
