// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Welcome to the even numbers from 1 finder!");
Console.WriteLine("Please, insert your number and we will show all even numbers from 1 to the one, that you inserted:");
var input = Console.ReadLine();
if (input == "1")
{
    Console.WriteLine("\u2205");
    return;
}

var targetNumber = default(int);
if (!int.TryParse(input, out targetNumber))
{
    Console.WriteLine("Sorry, program could not handle inserted value... Bye!");
    return;
}

var result = "2";
for (int i = 4; i <= targetNumber; i += 2)
{
    result += ", " + i;
}

Console.WriteLine(result);