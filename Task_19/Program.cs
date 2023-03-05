Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine() ?? "");
if (num<100000 && num>9999)
{
    if(DetermFifth(num) == DetermFirst(num) && DetermFourth(num) == DetermSecond(num))
    Console.WriteLine($"{num} является палиндромом");
    else
    Console.WriteLine($"{num} не является палиндромом");
}
else
{
    Console.WriteLine("Введено некорректиное число");
}

static int DetermFifth(int num)
{
    return num/10000;
}
static int DetermFourth(int num)
{
    return (num/1000)%10;
}
static int DetermFirst(int num)
{
    return num%10;
}
static int DetermSecond(int num)
{
    return (num/10)%10;
}