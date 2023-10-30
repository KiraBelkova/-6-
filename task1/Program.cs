// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int res = 0;

for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if(arr[i] > 0)
        {
            res++;
        }
    }

Console.WriteLine();
Console.WriteLine("Чисел больше нуля: " + res);
