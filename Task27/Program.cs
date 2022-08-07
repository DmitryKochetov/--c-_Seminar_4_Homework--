/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе. */

Console.Clear();

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
    Console.WriteLine("Вы ввели неправильное число");
}
else ShowMeSumOfDigit(num);

void ShowMeSumOfDigit(int number)
{
    int count = 0;
    
    while (number > 0)
    {
        count = count +  number % 10;
        number = number / 10;
    }
    
    Console.WriteLine($"Сумма цифр числа {num} -> {count}");
}
