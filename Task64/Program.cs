// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1.
void PrintNumber(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNumber(n - 1);
}
PrintNumber(10);
