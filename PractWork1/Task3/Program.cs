//Task3
Console.WriteLine("Введите имя файла:");
string filename = Console.ReadLine();
Console.WriteLine("Введите текст для поиска:");
string text = Console.ReadLine();

if (File.Exists(filename))
{
    string[] lines = File.ReadAllLines(filename);
    for (int i=0; i< lines.Length; i++)
    {
        if (lines[i].Contains(text))
            Console.WriteLine($"Текст содержится в строке {i+1}");
    }
}
else
    Console.WriteLine("Такого файла не существует");
