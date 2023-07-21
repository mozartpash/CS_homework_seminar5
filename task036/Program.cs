// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();

int[] FillArr(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(0, 10);
    }
    return num;
}

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(0, 10);        
    }
}

void Result(int[] num)
{
    int result = 0;
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
        result = num[1] + num[3];
    }
    Console.WriteLine();
    Console.Write($"Сумма элементов на нечётных позициях равна: {result}");
}

int[] array = new int[4];
PrintArray(array);
Result(FillArr(array));
