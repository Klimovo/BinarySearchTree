using MyLibrary;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        BinarySearchTree bst = new BinarySearchTree();

        // Додавання елементів у дерево
        bst.Add(50);
        bst.Add(30);
        bst.Add(70);
        bst.Add(20);
        bst.Add(40);
        bst.Add(60);
        bst.Add(80);

        // Перевірка наявності елементів
        Console.WriteLine($"Чи міститься число 50: {bst.Contains(50)}"); // true
        Console.WriteLine($"Чи міститься число 90: {bst.Contains(90)}"); // false

        // Отримання масиву з усіх елементів у дереві (впорядкований за зростанням)
        int[] array = bst.ToArray();
        Console.WriteLine("Масив елементів дерева:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

        // Очищення дерева
        bst.Clear();
        Console.WriteLine($"Кількість елементів після очищення: {bst.ToArray().Length}");

        Console.ReadLine();
    }
}
