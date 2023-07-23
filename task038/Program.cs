// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
Console.Clear();

double[] GetArray(int size, int rangeA, int rangeB)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * rangeA - rangeB;//Контролируем диапазон мин и макс умножением и вычитанием
        result[i] = Math.Round(result[i], 3);
    }
    return result;
}

double Diff(double[] arr)
{
    double result = 0;
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
        //Console.WriteLine("Макс " + max);
        if (min > arr[i]) min = arr[i];
        //Console.WriteLine("Мин " + min);
    }
    result = max- min;
    return result;
}
int rangeA = 10;
int rangeB = 5;

double[] Array = GetArray(5, rangeA, rangeB);
Console.WriteLine(String.Join("/", Array));
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {Diff(Array)}");