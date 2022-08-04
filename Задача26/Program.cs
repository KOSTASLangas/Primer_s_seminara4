// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

Console.WriteLine("введи число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (n != 0)  
{
        i++;
    n /= 10; 
}
Console.WriteLine(i);