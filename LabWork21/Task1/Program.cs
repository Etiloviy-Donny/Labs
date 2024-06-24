//Task1
int Sum(int number1, int number2)
{
    return number1 + number2;
}

//Task2
double r1 = 10;
double r2 = 5;
double s = Math.PI * (r1 - r2) * (r1 + r2);

int n = 50;
int sum = n * (n + 1) / 2;
Console.WriteLine(sum);

//Task3
int bytes = 1 << 45;
Console.WriteLine(GetSize(bytes));

string GetSize(int bytes)
{
    return (bytes < (1 << 10)) ? $"{bytes} Б" :
           (bytes < (1 << 20)) ? $"{bytes >> 10} КБ" :
           (bytes < (1 << 30)) ? $"{bytes >> 20} MБ" :
           $"{bytes >> 30} ГБ";
}

//Task4
int GetDaysCount(int month, int year)
{
    bool leapYear = year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
    int[] daysInMonths = { 31, leapYear ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    return month > 12 || month < 1 ? throw new ArgumentException("Неверный номер месяца") : daysInMonths[month - 1];
}
Console.WriteLine(GetDaysCount(2, 2024));

//Task5
int GetPower(int x, int n)
{
    return (n < 0) ? -1 : (n == 0) ? 1 :  x * GetPower(x, n - 1);
}
Console.WriteLine(GetPower(2, 8));
