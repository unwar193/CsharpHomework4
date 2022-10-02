// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵); 2, 4 -> 16
/* Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода */

Console.Write("Введите число А: ");
double a = Double.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = Int32.Parse(Console.ReadLine()!);

Console.WriteLine(Power(a, b));

double Power(double x, int y)
{
    double result = x;
    for(int i = 1; i < y; i++)
    {
        result *= x;
    }
    return result;
}