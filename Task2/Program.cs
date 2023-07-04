// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите положительное число N");
//int N = Convert.ToInt32(Console.ReadLine());

int countNums(int i)
{
    int count = 0;
    while (i > 0)
    {
        i /= 10;
        count++;
    }
    return count;
}

int[] createArray(int number, int size)
{
    int index = 0;
    int[] array = new int[size];

    while (number > 0)
    {
        array[index] = number % 10;
        number /= 10;
        index++;
    }
    return array;
}

int sumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
{
    Console.WriteLine($"Введенное число состоит из {countNums(N)} цифр");
    Console.WriteLine($"Массив: [{string.Join(";", createArray(N, countNums(N)))}]");
    Console.WriteLine($"Сумма цифр в веденном числе {N} = {sumNumbers(createArray(N, countNums(N)))}");
}
else
{
    Console.WriteLine("Введено некорректное число.");
}
