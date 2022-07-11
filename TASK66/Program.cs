/* 
Задача 66: 
    Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

* M = 1; N = 15 -> 120
* M = 4; N = 8. -> 30
 */
using System;
using static System.Console;

Clear();

WriteLine("Программа, выведет сумму натуральных чисел в промежутке от M до N.");
int m = new Random().Next(1,11);
int n = new Random().Next(1,11);

if (m>n)
{
    int tempValue = m;
    m=n;
    n=tempValue;
}

WriteLine ($"Сумма натуральных чисел в промежутке от {m} до {n} равно {MultiplicationNaturalNumbers (m,n)}");


int MultiplicationNaturalNumbers (int firstNumber, int secondNumer)
{
    if (firstNumber<secondNumer)  return secondNumer + MultiplicationNaturalNumbers (firstNumber, secondNumer - 1);
    
    else return secondNumer;
       
}