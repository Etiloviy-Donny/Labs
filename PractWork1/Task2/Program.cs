//Task2
Console.WriteLine("Введите имя файла:");
string filename = Console.ReadLine();

if (File.Exists(filename))
    Console.WriteLine($"Файл {filename} открыт на дозапись");
else
    Console.WriteLine($"Файл {filename} будет создан");

Console.WriteLine("для окончания дозаписи введиите 'end'"); 
while (true)
{
    string line = Console.ReadLine();
    if (line == "end")
    {
        Console.WriteLine("Запись окончина");
        break;
    }
    File.AppendAllText(filename, line);
}

