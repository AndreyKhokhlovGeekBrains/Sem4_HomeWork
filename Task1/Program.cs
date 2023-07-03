// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

double result = 0;

for(int i = 0; i <= B; i++)
{
    result = Math.Pow(A, i);
}

Console.WriteLine($"Число {A} в степени {B} = {result}");
