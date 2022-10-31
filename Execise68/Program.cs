// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AnkermanFunction(int em, int en)
{
    if (em == 0)
    {
        return en + 1;
    }
    else
        if ((em != 0) && (en == 0))
        {
        return AnkermanFunction(em - 1, 1);
        }
        else
            return AnkermanFunction(em - 1, AnkermanFunction(em, en - 1));
}

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int ankermanFunctionValue = AnkermanFunction(numberM, numberN);
Console.Write($"m = {numberM}, n = {numberN} -> A(m, n) = {ankermanFunctionValue}");