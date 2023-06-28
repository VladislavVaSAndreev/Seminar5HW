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
int num = 0;
for (int i = 0; i < arrey.Length; i++)
{
if(arrey[i]%2==0)
{
num++;
}
}
return num;
}
int Leng = redin($"Введите длинну массива");
int[] numberlist = GenerateArray(Leng, 100, 999);
PrintArrey(numberlist);
System.Console.WriteLine(count(numberlist));