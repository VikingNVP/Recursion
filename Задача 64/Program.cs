//  Задайте значение N. Напишите метод, который выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите число N: ");
bool isParse = int.TryParse(Console.ReadLine(), out int n);
int i = 1;
if(!isParse)
{
    Console.WriteLine("Ошибка! Не правильный ввод данных.");
}
Console.WriteLine(PrintNumbers(n, i));

int PrintNumbers(int n, int i)
{
    if (n == i)
    {
        return n;
    }
    else
        Console.Write($"{PrintNumbers(n, i + 1)}, ");
        return i;
}

