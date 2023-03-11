// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 8) {
    if (n > 5) {
        Console.Write("да");
    } else {
        Console.Write("нет");
    }
} else {
    Console.Write("В неделе только семь дней!");
}