// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System.Security.Cryptography;

int[] Create_Array(int length)
{
    int[] array = new int [length];
        for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 998);
    }
    return array;
}

int evennums = 0;

void CountOfEvenNums(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
        if ((array[i]%2) == 0)
        evennums += 1;
    }
}

Console.Write("Привет, я создаю массив с X трехзначными положительными числами и вывожу количество чётных чисел в массиве. Введи размер массива: ");
int start_num = Convert.ToInt32(Console.ReadLine());

int[] array_fin = Create_Array(start_num);
CountOfEvenNums(array_fin);
Console.Write($" -> {evennums}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

