//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число = ");
double A = double.Parse(Console.ReadLine()!);

if( A % 2 == 0 )
{
    Console.Write( A + " Четное " );
}
else
{
    Console.Write( A + " Нечетное " );
}