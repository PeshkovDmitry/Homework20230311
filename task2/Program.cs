// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99) {
    // int x = (n%100)/e(x);
} else {
    Console.Write($"{n}->третьей цифры нет");
}