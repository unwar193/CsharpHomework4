//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//Ограничения: - Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода 
//- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода

Console.WriteLine("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine()!);
int[] array = new int[arrayLength];

FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 10);
    }
}

void PrintArray(int[] x)
{
    int count = x.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}