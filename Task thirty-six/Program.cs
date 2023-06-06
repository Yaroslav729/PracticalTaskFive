// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int num = int.Parse(Console.ReadLine()!);
int[] array = new int[num];
void InputArray(int[] arr)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

int SumOdd = 0;

void SumOddPosition(int[] arr)
{
for (int i = 1; i < array.Length; i += 2)
{
    SumOdd += array[i];
}
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях: {SumOdd}");
}
SumOddPosition(array);