// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99) {
    while (n > 999) {
        n = n/10;
    } 
    Console.Write($"->{n%10}");
} else {
    Console.Write($"->третьей цифры нет");
}