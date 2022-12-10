// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(0, n) = n + 1,
// A(1, n) = n + 2,
// A(2, n) = 2n + 3,
// A(3, n) = 2n+3 – 3

System.Console.WriteLine(GetAkkerman(3, 2));

int GetAkkerman(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    if (m > 0 && n == 0) 
    {
        return GetAkkerman(m - 1, 1);
    }
    return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}
 

