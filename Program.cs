Console.WriteLine("Введите число N. Программа выведет все натйральные числа от N до 0");
int N = Convert.ToInt32(Console.ReadLine());

Function(N);

void Function(int n)
{
    Console.Write($"{n} ");
    if (n == 1)
        return;
    Function(n - 1);
}

Console.Read();