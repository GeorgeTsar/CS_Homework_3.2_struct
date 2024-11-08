using C__Homework_3._2;
using System;
using System.Runtime.ConstrainedExecution;

Console.WriteLine();

Fraction a = new(2, 3);
Fraction b = new(1, 2);

Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString());
Console.WriteLine(a.ToString() + " * " + b.ToString() + " = " + (a * b).ToString());
Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " + (a - b).ToString());
Console.WriteLine(a.ToString() + " / " + b.ToString() + " = " + (a / b).ToString());

Console.WriteLine();

Complex c = new(6, 7);
Complex d = new(3, 5);

Console.WriteLine(c.ToString() + " + " + d.ToString() + " = " + (c + d).ToString());
Console.WriteLine(c.ToString() + " * " + d.ToString() + " = " + (c * d).ToString());
Console.WriteLine(c.ToString() + " - " + d.ToString() + " = " + (c - d).ToString());
Console.WriteLine(c.ToString() + " / " + d.ToString() + " = " + (c / d).ToString());

Console.WriteLine();

Birthday e = new(20, 11, 1993);

Console.WriteLine(e.ToString());
Console.WriteLine();
Console.WriteLine(e.DayOfWeek(e));
Console.WriteLine();
Console.WriteLine(e.DayOfWeekThisYear(e, 2024));
Console.WriteLine();
Console.WriteLine(e.DaysToBirthday(e, 8, 11));

Console.WriteLine();


