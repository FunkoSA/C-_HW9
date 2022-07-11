/* 
Задача 68: 
    Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

* m = 2, n = 3 -> A(m,n) = 29

 */

 using System;
using static System.Console;

Clear();


long m = 3; 
long n = 0; 

WriteLine($"Программа вичисляет значение функции Аккермана с помощью рекурсии. Даны два неотрицательных числа {m} и {n}:");
WriteLine($"A({m},{n}) = {AckermannFunktion(m,n)}");

long  AckermannFunktion (long firstNumber, long secondNumer)
{
    if (firstNumber == 0) return secondNumer + 1;
    else if (firstNumber > 0 && secondNumer == 0) return AckermannFunktion(firstNumber - 1, 1);
    else if (secondNumer > 0 && firstNumber > 0)  return AckermannFunktion(firstNumber - 1, AckermannFunktion(firstNumber, secondNumer - 1));
    else return 0;

}

/*
взято с wikipedia:
A(m,n)
n+1                 m=0
A(m-1,1)            m>0, n=0
A(m-1), A(m,n-1)    m>0, n>0

*/