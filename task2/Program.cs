//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число = ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число = ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число = ");
int C = int.Parse(Console.ReadLine()!);


if( A > B && A > C)
{
    Console.WriteLine( A + " Максимальное " );
}
    if( B > C && B > A)
    {
        Console.WriteLine( B + " Максимальное " );
    }
    if ( C > A && C > B)
    {
        Console.WriteLine( C + " Максимальное " );
    }