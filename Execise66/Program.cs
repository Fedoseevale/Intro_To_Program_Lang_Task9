// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersFromMtoN(int num1, int num2)
{
    int result = num2;
    if (num1 == num2) return result;
    else return result + SumNumbersFromMtoN(num1, num2 - 1);
}


Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < numberN)
{
    int sum = SumNumbersFromMtoN(numberM, numberN);
    Console.Write($"Сумма натуральных элементов в промежутке от M до N: {sum}");
}

if (numberM > numberN)
{
    int sum = SumNumbersFromMtoN(numberN, numberM);
    Console.Write($"Сумма натуральных элементов в промежутке от M до N: {sum}");
}

if (numberM == numberN)
{
    Console.Write($"Сумма натуральных элементов в промежутке от M до N: {numberM}");
}
