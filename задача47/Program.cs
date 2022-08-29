// Программа задает массив случайных вещественных чисел, размером m*n
Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[, ] array = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().NextDouble()*100;
        Console.Write(String.Format("{0,5:f1}", array[i, j] + " "));
    }
    Console.WriteLine();
}
