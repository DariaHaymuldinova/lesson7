// Программа задает массив случайных вещественных чисел, размером m*n
Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().NextDouble() * 10;
        string result = string.Format("{0:f1}", array[i, j]);
        Console.Write(result + " ");
    }
    Console.WriteLine();
}
