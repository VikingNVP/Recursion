// Напишите метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите положительное число M: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите положительное число N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка! Не правильный ввод данных.");
}

Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
