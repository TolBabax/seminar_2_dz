// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//Математический вариант

// Console.Write("Введите число трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int number1 = number / 10;
// int number2 = number1 % 10;

// if(number < 100 || number > 999)
// {
//     System.Console.WriteLine("Введите трехзначное число.");
// }
// else
// {
//     System.Console.WriteLine($"Число {number2} вторая цифра {number}");
// }


// Вариант с массивом

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
char[] str = new char[number.Length];
if(number.Length == 3)
{
    Console.WriteLine($"Вторая цифра трехзначного числа: {number[1]}");
}
else
{
    Console.WriteLine("Введите трехзначное число.");
}

   