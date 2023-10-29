// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] Create_Array(int length)
{
    double[] array = new double [length];
     Console.WriteLine("Ввод переменных через разделитель Enter:");
        for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

double diff = 0;

void DiffBtwnMinAndMax(double[] array)
{
    double min = array [0];        
    double max = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<min)
        min = array[i];
        if (array[i]>max)
        max = array[i];
    }
    diff = max - min;
    Console.WriteLine($" => {max} - {min} = {diff}");
}

Console.Write("Привет, я создаю массив с дробными числами и ищу разницу между максимальным и минимальным. Введи размер массива: ");
int start_num = Convert.ToInt32(Console.ReadLine());

double[] array_fin = Create_Array(start_num);
DiffBtwnMinAndMax(array_fin);