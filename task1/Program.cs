﻿// Задача 10. Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа 
Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 && n < 1000) {
    int x = (n%100)/10;
    Console.WriteLine(x);
} else {
    Console.Write("Необходимо ввести именно трехзначное число!");
}