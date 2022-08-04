// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
Console.WriteLine("введи число");
int n = Convert.ToInt32(Console.ReadLine());
int factorial = 1;

for (int i = 1; i <= n; i++)
    factorial = factorial * i;

Console.WriteLine(factorial);
// int n = 5;  // количество циклов в факториале
// int factorial = 1;   // значение факториала

// for (int i = 2; i <= n; i++) // цикл начинаем с 2, т.к. нет смысла начинать с 1
// {
//      factorial = factorial * i;
// }