 //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число = ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число = ");
int B = int.Parse(Console.ReadLine()!);
if ( A > B)
{
    Console.WriteLine( A +  " Большее " );
    Console.WriteLine( B +  " Меньшее " );
}
else
{
    Console.WriteLine( B +  " Большее " );
    Console.WriteLine( A +  " Меньшее " );
}