// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


void findSecondNumber(int start, int finish)
{
    int num = new Random().Next(start, finish);
    Console.WriteLine(num);
    int secondnum = num % 100 /10;
    Console.WriteLine(secondnum);
}

findSecondNumber(100, 999);