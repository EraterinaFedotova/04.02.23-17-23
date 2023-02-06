// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;
string txt = number.Replace(" ","");  /// для проверки текста на палиндром

bool Pal()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (Pal()) 
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else 
{
    Console.WriteLine($"Число {number} не является палиндромом");
}