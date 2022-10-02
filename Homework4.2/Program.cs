//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11; 82 -> 10; 9012 -> 12; 
//Ограничения: - Должна быть отдельная функция, которая возвращает результат суммы цифр. Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Write("Введите число: ");
int num = Int32.Parse(Console.ReadLine()!);

int Sum (int x){
    int result = 0;
    while (x > 10){
        result = result + (x%10);
        x = x/10;
    }
    result = result + x;
    return result;
}

Console.WriteLine(Sum(num));