//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

System.Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 1)
{System.Console.WriteLine("нет");}
else if(day == 2)
{System.Console.WriteLine("нет");}
else if(day == 3)
{System.Console.WriteLine("нет");}
else if(day == 4)
{System.Console.WriteLine("нет");}
else if(day == 5)
{System.Console.WriteLine("нет");}
else if(day == 6)
{System.Console.WriteLine("да");}
else if(day == 7)
{System.Console.WriteLine("да");}