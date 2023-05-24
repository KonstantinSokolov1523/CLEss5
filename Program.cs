/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. 
Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

/*int[] genarray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
Console.WriteLine(String.Join(",", array));
    return array;
}
int[] array = genarray();
int even = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        even +=1;
    }
}
Console.WriteLine(even);
*/
/*Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
 [3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*int[] genarray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
Console.WriteLine(String.Join(",", array));
    return array;
}
int[] array = genarray();
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i%2 == 0)
    {
        sum +=array[i];
    }
}
Console.WriteLine(sum);
*/
/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
Диапазон [-10, 10]. Обратите внимание 
на вещественных чисел
Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76 */
/*
double[] genarray()
{
    double[] array = new double[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10);
    }

    return array;
}
double[] array = genarray();
double min = 10;
double max = -10;
for (int i = 0; i < array.Length; i++)
{
    if(min > array[i])
    {
        min = array[i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if(max < array[i])
    {
        max = array[i];
    }
}
Console.WriteLine(String.Join(",", array) + " -> " + (max - min));
*/