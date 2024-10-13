//Написать функцию, которая принимает натуральное число
//и возвращает строку,
//содержащую запись этого числа римскими цифрами.

Console.WriteLine("Введи число от 1 до 3999: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(convert_to_rim(num));

static string convert_to_rim(int num)
{
    int[] arab = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string[] rim = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    string result = "";
    for (int i = 0; i < 13; i++)
    {
        while (num >= arab[i])
        {
            num -= arab[i];
            result+=(rim[i]);
        }
    }
    return result;
}
