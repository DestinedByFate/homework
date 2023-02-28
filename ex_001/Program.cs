// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumber(int input)
{
    if (input >= 100)
    {
        int secNum = input / 10 % 10;
        Console.Write($"Second number of {input} is {secNum}.");
    }
    else Console.Write("No, no! Input a three-digit number!");
    return input;
}

Console.Write("Input a three-digit number: ");
int input = Convert.ToInt32(Console.ReadLine());

Console.Write(SecondNumber(input));