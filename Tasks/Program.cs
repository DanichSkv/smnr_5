﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

Console.Write("Привет, я создаю массив с X трехзначными положительными числами и вывожу количество чётных чисел в массиве, сумму элементов, стоящих на нечётных позициях. Введи размер массива: ");
int start_num = Convert.ToInt32(Console.ReadLine());

int SumNotEvenNums = 0;

int[] array_fin = Create_Array(start_num);
CountOfEvenNums(array_fin);
Console.WriteLine($" -> {evennums};");
SumOfNotEvenPositionNums(array_fin);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {SumNotEvenNums}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void SumOfNotEvenPositionNums(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if ((i%2) != 0)
        SumNotEvenNums += array[i];
    }
}