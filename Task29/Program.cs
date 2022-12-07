// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



Console.Write("На сколько элементов Вам требуется массив? Введите число: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
     array[i] = new Random().Next(100);
 }
 Console.Write("[" + string.Join(", ", array) + "]");