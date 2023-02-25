// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// int size = new Random().Next(3, 20);
// int minValue = 100;
// int maxValue = 999;

// int[] arr = GetArray(size, minValue, maxValue);
// int count = 0;

// for (int i = 0; i < size; i++)
// {
//     if (arr[i]%2 == 0) count +=1;
// }

// Console.WriteLine(String.Join("; ", arr));
// Console.WriteLine($"Заданный массив содержит {count} четных элементов");


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }





// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int size = new Random().Next(3, 20);
// int minValue = -99;
// int maxValue = 99;

// int[] arr = GetArray(size, minValue, maxValue);
// int sum = 0;

// for (int i = 1; i < size; i += 2)
// {
//     sum += arr[i];
// }

// Console.WriteLine(String.Join("; ", arr));
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равнв {sum}");


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }




// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

int size = new Random().Next(3, 20);
double[] arr = GetArrayDouble(size);

double min = arr[0];
double max = arr[0];

for (int i = 1; i < size; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
    else if (arr[i] > max)
    {
        max = arr[i];
    }
}

Console.WriteLine(String.Join("; ", arr));
Console.WriteLine($"Разница между минимальным элементом {min} и максимальным {max} равна {max-min}");


double[] GetArrayDouble(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        int z = new Random().Next(1, 3);
        if (z == 2) z = -1;
        result[i] = z * Math.Round((new Random().NextDouble()) * 100, 2);
    }
    return result;
}