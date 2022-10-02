/* // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
/*  */

/* int[] array = {-4, -8, 8, 2};
int length = array.Length; 
for (int i = 0; i <= length; i++)
{
    array[i] *= -1;
    Console.Write($"{array[i] }");
}
 */ 

 Console.Clear();

int arrayLenght = 10;
 
int[] array = new int[arrayLenght];
 
FillArray(array);
PrintArray(array);
CountNumbers(array);
 
void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0, 201);
    }
}
 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void CountNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < arrayLenght; i++ )
    {
        if(array[i]>10 && array[i] < 99)
        {
           count ++;            
        } 
    };
    Console.WriteLine($"Ответ: " + count);
}



