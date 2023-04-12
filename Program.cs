// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999)
// {
//     int rem = (num/10)%10;
//     Console.WriteLine("Вторая цифра этого числа: " + rem);
// }
// else if (num >= -999 && num <= -100)
// {
//     int rem = ((num/10)%10) * -1;
//     Console.WriteLine("Вторая цифра этого числа: " + rem);
// }
// else
// {
//     Console.WriteLine(num + " - не является трёхзначным числом");
// }


// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100)
// {
//     string str = Convert.ToString(num);
//     Console.WriteLine("Третья цифра этого числа: " + str[2]);
// }
// else if (num <= -100)
// {
//     string str = Convert.ToString(num);
//     Console.WriteLine("Третья цифра этого числа: " + str[3]);
// }
// else
// {
//     Console.WriteLine(num + " третьей цифры нет");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите число");
// int num=Convert.ToInt32(Console.ReadLine());

// if(num >= 1 && num <= 5)
// {
//     Console.WriteLine("Рабочий день");
// }
// else if(num ==6 || num == 7)
// {
//     Console.WriteLine("Выходной день");   
// }

// else
// {
//     Console.WriteLine("Такого дня не существует");
// }