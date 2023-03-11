// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.WriteLine("введите число N:");
int N=Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Вывести все натуральные числа в промежутке от N до 1.
/// </summary>
/// <param name="start"> start=N </param>
/// <param name="end"> end=1 </param>
/// <returns> числа от N до 1 </returns>
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return(start+","+PrintNumbers(start-1,end));
}
Console.WriteLine(PrintNumbers(N,1));
