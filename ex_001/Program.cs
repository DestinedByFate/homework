// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// void SecondNumber(int input)
// {
//     if (input >= 100 || input <= 1000)
//     {
//         int secNum = input / 10 % 10;
//         Console.Write($"Second number of {input} is {secNum}.");
//     }
//     else Console.Write("No, no! Input a three-digit number!");
// }

// Console.Write("Input a three-digit number: ");
// int input = Convert.ToInt32(Console.ReadLine());

// SecondNumber(input);

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Input a third number digit: ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("RRRR");
    return;
} 

Console.WriteLine($"Input a number {number}");
int SecondRank = number / 10 % 10;
Console.WriteLine($"Second digit is: {SecondRank}");