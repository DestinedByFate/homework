// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int ThirdDigit(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int textnumber = ThirdDigit("Input a third digit number: ");
if (textnumber < 100)
{
    Console.Write("Oops, third number is gone! ^_^ Repeat it.");
    return;
}

int number = textnumber % 10;
Console.WriteLine($"Third digit of {textnumber} is {number}");


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
