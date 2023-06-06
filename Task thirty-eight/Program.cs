// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int num = int.Parse(Console.ReadLine()!);
double[] array = new double[num];
void InputArray(double[] arr)
{
    int end = 30, begin = 10;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
    }
}
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

double max = 0;
double min = array[0];
void GapNumber(double[] arr)
{
for (int i = 0; i < array.Length; i ++)
{ 
    if(max < array[i])
    max = array[i];

    else if (min > array[i])
    min = array[i];
    
}
Console.WriteLine($"min число: {min}");
Console.WriteLine($"max число: {max}");
Console.WriteLine($"разницf между максимальным и минимальным элементом массива: {max - min}");
}
GapNumber(array);
