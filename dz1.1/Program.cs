
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < num+1; i++)
{
    if (Prostoe_li(i))
    {
        Console.WriteLine(i);
    }
}
    

bool Prostoe_li(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}