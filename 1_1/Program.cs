// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число:");
int firstnumber = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите второе число:");
int secondnumber = Convert.ToInt32(Console.ReadLine ());
if (firstnumber > secondnumber)
{
    Console.WriteLine (firstnumber);
}
else
{
    Console.WriteLine (secondnumber);
}
