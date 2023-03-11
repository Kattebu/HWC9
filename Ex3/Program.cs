// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.WriteLine("введите  неотрицательное чило M:");
int firstNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите неотрицательное  чило N:");
int secondNumber=Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Вычисление функции Аккермана
/// </summary>
/// <param name="m">первое число</param>
/// <param name="n">второе число</param>
/// <returns>функция Аккермана</returns>
int AkkermanFunction(int m, int n)
{
    if(m==0) return n+1;
    else if((m!=0) && n==0) return AkkermanFunction(m-1,1);
        else return AkkermanFunction(m-1,AkkermanFunction(m,n-1));
}
Console.WriteLine(AkkermanFunction(firstNumber, secondNumber));