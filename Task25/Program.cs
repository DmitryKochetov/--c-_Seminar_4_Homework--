/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.*/

Console.Clear();

Console.WriteLine("Введите целое положительное число a");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число b");
int numB = Convert.ToInt32(Console.ReadLine());

int res = 0;

if (numA <= 0 || numB <= 0)
{
    Console.WriteLine("Вы ввели неправильное число");
}
else 
{
    /* проще всего было бы сделать так, но по условиям задачи нужен цикл
    int result = Convert.ToInt32(Math.Pow(numA, numB));
    Console.WriteLine($"число a возведенное в степень b = {result}"); */
    
    Console.WriteLine($"число a возведенное в степень b = {PowAB(numA, numB)}"); 
}

int PowAB(int num, int n)
{
    int result = num;
    for (int i = 1; i < n; i++)
    {
        result *= num;
    }
	return result;
}
