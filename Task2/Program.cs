int[] GenerateArray(int len, int min, int max)
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}
int redin(string tex)
{
    Console.WriteLine(tex);
    string number = Console.ReadLine();
    int Leng = Convert.ToInt32(number);
    int min = Convert.ToInt32(number);
    int max = Convert.ToInt32(number);
    return Leng;
}


void PrintArrey(int[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + " ");
    }
    System.Console.WriteLine();
}

int count(int[] arrey)
{
    int sum = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum=sum+arrey[i];
        }
    }
    return sum;
}
int Leng = redin($"Введите длинну массива");
int min = redin($"Введите минимальное число массива");
int max = redin($"Введите максимальное число массива");
int[] numberlist = GenerateArray(Leng, min, max);
PrintArrey(numberlist);
System.Console.WriteLine(count(numberlist));