double[] GenerateArray()
{
    double[] list1 = new double[6];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(0, 100) + rnd.NextDouble();
    }
    return list1;
}
void PrintArray(double[] Array)
{
    Console.Write($"Массив -->");
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"\t{Array[i]}");
    }
}

double[] list1 = GenerateArray();
PrintArray(list1);

double min = list1[0];
double max = 0;
for (int i = 0; i < list1.Length; i++)
{
    if (min > list1[i])
    { min = list1[i];}
    if (max < list1[i])
    { max = list1[i];}
}
double diff = max-min;
System.Console.WriteLine($"\nМинимальное число в массиве--> {min}\nМаксимальное число в массиве -->{max}");
System.Console.WriteLine();
System.Console.WriteLine($"Разница между max и min -->{diff}");
