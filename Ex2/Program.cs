// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("введите  первое чило M:");
int firstNumber=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе чило N:");
int secondNumber=Convert.ToInt32(Console.ReadLine());
int sum=0;
/// <summary>
/// Выводим натуральные эдлементы от M до N.
/// </summary>
/// <param name="firstNum"> firstNum=M</param>
/// <param name="secondNum"> secondNum=N</param>
/// <param name="sum"> сумма элементов </param>
/// <returns>сумма элементов от M до N</returns>
int SumNumbers(int firstNum, int secondNum, int sum)
{
    if(firstNum==secondNum+1) return sum;
    return firstNum+SumNumbers(firstNum+1,secondNum,sum);
}
Console.WriteLine($"Сумма элементов от M до N: {SumNumbers(firstNumber, secondNumber, sum)}");
