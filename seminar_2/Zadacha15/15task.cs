// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели, чтобы узнать, выходной ли это.");
int num = Convert.ToInt32(Console.ReadLine());
string[] weekDays = new string[] { "Понедельник, нет", "Вторник, нет", "Среда, нет", "Четверг, нет", "Пятница, нет", "Суббота, да", "Воскресенье, да" };

Console.WriteLine(weekDays[num-1]);