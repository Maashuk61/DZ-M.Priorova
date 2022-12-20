// Напишите программу, которая принимает на вход три числа,
// и выдаёт максимальное из этих чисел

Console.WriteLine("Введите первое число:");
int firstnumber = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите второе число:");
int secondnumber = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите третье число:");
int thirdnumber = Convert.ToInt32(Console.ReadLine ());

int max = firstnumber;
if (firstnumber < secondnumber) max = secondnumber;
if (secondnumber < thirdnumber) max = thirdnumber;

 Console.WriteLine (max);