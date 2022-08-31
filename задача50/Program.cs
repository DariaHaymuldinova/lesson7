// 
int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(String.Format(array[i, j] + " "));
    }
    Console.WriteLine();
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Find(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"{i}, {j}");
                continue;
                return true;
            }

        }
    }
    return false;
}
if (Find(array))
{
    Console.WriteLine("Такого числа нет");
}
else
{
    Console.WriteLine("Такого числа нет");
}
