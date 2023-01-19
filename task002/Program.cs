// Задача 13: Напишите программу, 
//которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number/100);
if (result == 0)
{
    System.Console.WriteLine($"третьей цифры нет");
}
   else
  {
    string str = number.ToString();
    System.Console.WriteLine(str[2]);
  }