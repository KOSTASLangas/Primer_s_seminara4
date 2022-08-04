// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.

int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;
for (int i = 1; i <= n; i++)    // 1. переменная исп в цикле фор. 2. условие работы цикла. 3. счетчик ув. значение i
    summa += i;
Console.WriteLine(summa);

// Второй способ решения задачи
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(((n + 1) / 2) * n);