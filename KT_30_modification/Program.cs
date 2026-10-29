using System;
using System.Collections.Generic;

namespace KT_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ДЕМОНСТРАЦИЯ МЕТОДОВ РАСШИРЕНИЯ С ВВОДОМ ОТ РУКИ ===\n");

            Console.WriteLine("--- Работа со списком чисел (List<int>) ---");
            List<int> numbers = new List<int>();

            Console.Write("Сколько элементов вы хотите добавить в список int? ");
            if (int.TryParse(Console.ReadLine(), out int intCount))
            {
                for (int i = 0; i < intCount; i++)
                {
                    Console.Write($"Введите элемент {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int val))
                    {
                        numbers.Add(val);
                    }
                }
            }

            if (numbers.Count == 0)
            {
                numbers = new List<int> { 1, 2, 3 };
                Console.WriteLine("Список был пустым, автоматически загружены значения по умолчанию: 1, 2, 3");
            }

            Console.WriteLine($"\nИсходный список int: {string.Join(", ", numbers)}");
            Console.WriteLine($"Список int пуст? {numbers.IsEmpty()}");

            if (numbers.Count >= 2)
            {
                Console.Write("Введите индекс первого элемента для Swap: ");
                int idx1 = int.TryParse(Console.ReadLine(), out int i1) ? i1 : 0;

                Console.Write("Введите индекс второго элемента для Swap: ");
                int idx2 = int.TryParse(Console.ReadLine(), out int i2) ? i2 : numbers.Count - 1;

                numbers.Swap(idx1, idx2);
                Console.WriteLine($"После Swap({idx1}, {idx2}): {string.Join(", ", numbers)}");
            }

            Console.WriteLine("\n----------------------------------------\n");

            Console.WriteLine("--- Работа со списком строк (List<string>) ---");

            List<string> emptyList = new List<string>();
            Console.WriteLine($"Новый пустой список строк. IsEmpty(): {emptyList.IsEmpty()} (ожидается: True)");

            List<string> stringList = new List<string>();
            Console.Write("Сколько строк вы хотите добавить в список string? ");
            if (int.TryParse(Console.ReadLine(), out int strCount))
            {
                for (int i = 0; i < strCount; i++)
                {
                    Console.Write($"Введите строковый элемент {i + 1}: ");
                    string s = Console.ReadLine();
                    if (s != null) stringList.Add(s);
                }
            }

            if (stringList.Count == 0)
            {
                stringList = new List<string> { "a", "b", "c" };
                Console.WriteLine("Список был пустым, автоматически загружены значения по умолчанию: a, b, c");
            }

            Console.WriteLine($"\nЗаполненный список string: {string.Join(", ", stringList)}");
            Console.WriteLine($"Заполненный список пуст? {stringList.IsEmpty()} (ожидается: False)");

            if (stringList.Count >= 2)
            {
                stringList.Swap(0, stringList.Count - 1);
                Console.WriteLine($"После обмена первого и последнего элементов (Swap): {string.Join(", ", stringList)}");
            }

            Console.WriteLine("\nРабота программы успешно завершена.");
        }
    }
}