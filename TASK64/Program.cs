/*
 Задайте значения M и N. Напишите программу, которая выведет произведение натуральных чисел в промежутке от M до N.

* M = 1; N = 5. ->120

* M = 4; N = 6. -> 120 
*/

using System;
using static System.Console;

Clear();

WriteLine("Программа, выведет произведение натуральных чисел в промежутке от M до N.");
int m = new Random().Next(1,11);
int n = new Random().Next(1,11);

if (m>n)
{
    int tempValue = m;
    m=n;
    n=tempValue;
}

WriteLine ($"Произведение натуральных чисел в промежутке от {m} до {n} равно {MultiplicationNaturalNumbers (m,n)}");


int MultiplicationNaturalNumbers (int firstNumber, int secondNumer)
{
    if (firstNumber<=secondNumer)  return secondNumer * MultiplicationNaturalNumbers (firstNumber, secondNumer - 1);
    
    else return 1;
       
}