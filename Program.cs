using System;
using static System.Console;
Write ("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(ReadLine());
    arrayStrings[i] = element;
}
