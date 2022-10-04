// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Введите количество чисел для ввода M=");
int num=Convert.ToInt32(Console.ReadLine());

int[] array=new int[num];
int count=0;
Console.WriteLine("Введите числа ");
for (int i = 0; i < array.Length; i++)
{
    array[i]=Convert.ToInt32(Console.ReadLine());
    if (array[i]>0) count+=1; 
}
Console.Write($"Количество положительных введенных чисел равно {count}");