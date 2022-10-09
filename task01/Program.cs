// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите M");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];

for (int i = 0; i < size; i++)
    {
    Console.WriteLine($"введите {i+1}-ое значение");
    int k = Convert.ToInt32(Console.ReadLine()); 
    array[i] = k;
    }
    

void PrintArray (int[] array) 
{
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, "); 
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

PrintArray(array);

PositiveNumbers(array);
int PositiveNumbers (int[] array)
{
    int counter = default;
    for (int i = 0; i < size; i++)
    {
       if (array[i] > 0) counter ++; 
    }
    return counter;
}   

int counter = PositiveNumbers (array);
Console.WriteLine($"количество положительных чисел в массиве = {counter}");

