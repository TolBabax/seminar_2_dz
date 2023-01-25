// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число обозначающее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 6 || number == 7 )
{
    Console.WriteLine("Этот день недели является выходным");
}
if(number < 1 || number > 7)
{
    Console.WriteLine("В неделе 7 дней. Введите число от 1 до 7");
}
else if(number > 0 && number < 6)
{
    Console.WriteLine("Этот день недели не является выходным");
}