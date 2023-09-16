// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
}
void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();

}
int SumNumbers(int[] array1) 
{
    int result = 0;  
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i]%2==0)
        result = result + 1;
    }
    return result;
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
System.Console.WriteLine("Количество четных чисел массива: " + SumNumbers(array));




