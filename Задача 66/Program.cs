// Задайте значения M и N. Напишите метод, который найдёт сумму натуральных элементов в промежутке от M до N. Через рекурсию!
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число M: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if(!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка! Не правильный ввод данных.");
}

Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}
