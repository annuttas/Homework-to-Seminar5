// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример:
// [345, 897, 568, 234] -> 2

int count = 0;
int[] array = new int[4];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($" {array[i]} ");
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
}
Console.Write($"] -> {count}");