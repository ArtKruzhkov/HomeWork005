//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// int[] array = GetArray(5, 100, 1000);
// Console.WriteLine(String.Join(" ", array));
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for(int i = 0; i < size; i++ )
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// int EvenCount(int[] arr)
// {
//     int count = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] % 2 == 0)
//         {
//             count = count + 1;
//         }
//     }
//     return count;
// }
// int evencount = EvenCount(array);
// Console.WriteLine($"Even digits in this array = {evencount}"); 

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] array = GetArray(7, -10, 99);
// Console.WriteLine($"[{String.Join(" ", array)}]");
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for(int i = 0; i < size; i++ )
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// int SumElementsOddindex(int [] arr)
// {
//     int Sum = 0;
//     for(int index = 1; index < arr.Length; index = index + 2)
//     {
//         Sum = Sum + arr[index];
//     }
//     return Sum;
// }
// int SumElements = SumElementsOddindex(array);
// Console.WriteLine($"Sum for elements with odd index = {SumElements}");

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
// int[] array = GetArray(7, 0, 99);
// Console.WriteLine(String.Join(" ", array));
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for(int i = 0; i < size; i++ )
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// int DiffMaxMin(int[] arr)
// {
//     int max = arr[0];
//     int min = arr[1];
//     int Diff = 0;
//     for(int index = 0; index < arr.Length; index++)
//     {
//         if(arr[index] > max)
//         {
//             max = arr[index];
//         }
//         else if(arr[index] < min)
//         {
//             min = arr[index];
//         }
//         Diff = max - min;
//     }
//     return Diff;
// }
// Console.WriteLine($"Diffirence between max element and min element = {DiffMaxMin(array)}");