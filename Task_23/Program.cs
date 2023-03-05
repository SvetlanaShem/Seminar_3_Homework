Console.Clear();
int num = InputNumber("Введите число ");
Console.WriteLine($"Таблица кубов чисел от 1 до {num}: ");
Cubes(num);
static int InputNumber(string message)
{
    try
    {
        Console.Write(message);
        return (int.Parse(Console.ReadLine() ?? ""));
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

static void Cubes(int num)
{
    for (int i = 1; i <= num; i++)
{
   Console.Write($"{i * i * i}, ");
}
}