// Программа задает массив и выводит среднее арифметическое по столбцам с точностью до десятых
int[, ] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0,11);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

void Average (int[, ] array)
{
    double Sum1 = 0;
    double Sum2 = 0;
    double Sum3 = 0;
    double Sum4 = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    if (j == 0)
    {
        Sum1 = Sum1 + array[i, j];
    }
    if (j == 1)
    {
        Sum2 = Sum2 + array[i, j];
    }
    if (j == 2)
    {
        Sum3 = Sum3 + array[i, j];
    }
    if (j == 3)
    {
        Sum4 = Sum4 + array[i, j];
    }
    }
    
}
string result1 = string.Format("{0:f1}", Sum1 / 3);
string result2 = string.Format("{0:f1}", Sum2 / 3);
string result3 = string.Format("{0:f1}", Sum3 / 3);
string result4 = string.Format("{0:f1}", Sum4 / 3);
Console.WriteLine( result1 + " " + result2 + " " + result3 + " " + result4);
}
Average(array);
