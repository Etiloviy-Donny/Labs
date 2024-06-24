using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создание списка строк "Машины"
        List<string> Машины = new List<string>();

        // Добавление 3 элементов программно
        Машины.Add("Toyota");
        Машины.Add("Honda");
        Машины.Add("Ford");

        // Заполнение списка с клавиатуры
        Console.WriteLine("Введите количество элементов для добавления: ");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            // Запрос элемента у пользователя
            Console.WriteLine("Введите элемент " + (i + 4) + ":");
            string элемент = Console.ReadLine();
            // Добавление элемента в список
            Машины.Add(элемент);
        }

        // Вывод на экран элементов списка
        Console.WriteLine("Элементы списка Машины:");
        for (int i = 0; i < Машины.Count; i++)
        {
            // Вывод номера и значения элемента
            Console.WriteLine((i + 1) + " - " + Машины[i]);
        }

        // Вывод количества элементов в списке
        Console.WriteLine("Количество элементов в списке: " + Машины.Count);
    }
}