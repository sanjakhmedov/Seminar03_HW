// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Enter the 5 digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

int n0 = n / 10000;
int n1 = n / 1000 % 10;
int n2 = n / 100 % 10;
int n3 = n / 10 % 10;
int n4 = n % 10;
Console.WriteLine(n4);

if (n0 == n4 && n1 == n3) 
{
    Console.WriteLine($"Number '{n}' is Palindrome");
}
else 
{
    Console.WriteLine($"Number '{n}' is NOT Palindrome");
}