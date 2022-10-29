// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на етных позициях
int[] array = new int[12];
void FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-12, 12);
}
}
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write($"{array[array.Length - 1]} ");
}
PrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);