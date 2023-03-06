// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumebr(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Oops, third number is gone! ^_^ Repeat it.");
        return false;
    }
    return true;
}

int number = Prompt("Enter a digit: ");
if (ValidateNumebr(number))
{
    Console.WriteLine(GetThirdRank(number));
}


// int textnumber = ThirdDigit("Input a third digit number: ");
// if (textnumber < 100)
// {
//     Console.Write("Oops, third number is gone! ^_^ Repeat it.");
//     return;
// }

// int number = textnumber % 10;
// Console.WriteLine($"Third digit of {textnumber} is {number}");


// int Factorial(int n)
// {
//     if (n == 1) return 1;
 
//     return n * Factorial(n - 1);
// }
 
// int factorial4 = Factorial(4);  // 24
// int factorial5 = Factorial(5);  // 120
// int factorial6 = Factorial(6);  // 720
 
// Console.WriteLine($"Факториал числа 4 = {factorial4}");
// Console.WriteLine($"Факториал числа 5 = {factorial5}");
// Console.WriteLine($"Факториал числа 6 = {factorial6}");
