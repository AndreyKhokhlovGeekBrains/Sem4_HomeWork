// Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит 
// их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// (каждый элемент вводит человек)

int size = 8;
int[] myArray = new int[size];

int[] createArray(int[] array)
{
    int i = 0;
    while(i < array.Length)
    {
        Console.WriteLine("Введите число: ");
        if(int.TryParse(Console.ReadLine(), out int num))
        {
            array[i] = num;
            i++;
        }
        else
        {
            Console.WriteLine("Введено некорректное число");
        }
    }
    return myArray;
}

void printArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(";", array)}]");
}

printArray(createArray(myArray));
