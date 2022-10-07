/*Напишите программу, котрая на вход принимает два числе и выдаёт, какое
число более, а какое меньшее*/


Console.WriteLine("Введите числo a ");

Console.WriteLine("Введите числo b ");

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberB > numberA)
{
    Console.WriteLine("число b больше числа a");
}
else Console.WriteLine("число a больше числа b");

