// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
void InputArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array )}]");

void EvenNuber(int[] arr)
{
int sumEven = 0;
foreach (int element in arr)
{
    if (element % 2 == 0)
    sumEven ++;
}
Console.WriteLine($"Количество чётных чисел в массиве: {sumEven}");
}
EvenNuber(array);