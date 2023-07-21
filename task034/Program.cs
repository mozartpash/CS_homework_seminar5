// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] FillArr(int [] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);        
    }
    return num;
}

void Print(int [] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
}

void Result(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {    
    if(array[i]%2 == 0) count++;
    }
    Console.WriteLine($"Колличество чётных чисел в массиве: {count}");
        
}

int size = Promt("Введите размер массива: ");
int [] array = new int[size];

Print(FillArr(array));
Result(FillArr(array));
