// Напишите программу, которая на вход принимает число (N), на выходе показывает все четные числа от 1 до N.

Console.Clear();
Console.WriteLine("Напишите число 1");
int n = int.Parse(Console.ReadLine());
Console.WriteLine ("Напишите число 2");
int m = int.Parse(Console.ReadLine());
for (int i=n; i<=m, i++)
{
    if(i%2==0)
    {
        Console.Write(i + "");
    } 
}
ConsoleKey();