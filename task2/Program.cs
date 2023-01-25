// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//математичский способ

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberinter = 0;
if(number >= 0 && number < 100 )
{
    System.Console.WriteLine($"В этом числе {number} нет третьей цифры.");
}
else 
{
    if(number > 99 && number < 1000 )
    {
        System.Console.WriteLine($"Третья цифра введеного числа: {number % 10}");
    }
    else 
    {
        while(number > 999 )
        {
         numberinter = number / 10;
         number = numberinter;
        }
        System.Console.WriteLine($"Третья цифра введеного числа: {numberinter % 10}");
    }
}

// массив

// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// char[] str = new char[number.Length];
// if(number.Length > 2)
// {
//     Console.WriteLine($"Третья цифра числа: {number[2]}");
// }
// else
// {
//     Console.WriteLine("Введите число с количеством знаков больше 2");
// }