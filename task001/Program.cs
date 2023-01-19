// Задача 10: Напишите программу,
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

System.Console.WriteLine("Введите трёхзначное число");
//int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToInt32(Console.ReadLine()).ToString();
System.Console.WriteLine(str[1]);