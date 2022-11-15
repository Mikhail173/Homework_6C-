//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

 
Console.Write("Amount of numbers : ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] a = new int[n];
for(int i = 0; i < n; i++)
{
    Console.Write($"A[{i + 1}] = ");
    a[i] = Convert.ToInt32(Console.ReadLine());
    if (a[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Amount of positive numbers : {sum}");  
 