using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework_3._2
{
    struct Fraction
    {
        public int numerator;
        public int denominator;
        public Fraction(int n, int d)
        {
            numerator = n;
            denominator = d;
        }

        // Вывод дроби (в виде строки)
        public override string ToString()
        {
            return numerator.ToString() + "/" + denominator.ToString();
        }

        // Метод сложения дробей
        public static Fraction operator + (Fraction a, Fraction b)
        {
            Fraction t = new Fraction(1, 1);
            t.numerator = (a.numerator * b.denominator + a.denominator * b.numerator);
            t.denominator = a.denominator * b.denominator;
            return t;
        }

        // Метод вычитания дробей
        public static Fraction operator - (Fraction a, Fraction b)
        {
            Fraction t = new Fraction(1, 1);
            t.numerator = (a.numerator - b.numerator);
            t.denominator = a.denominator;
            return t;
        }

        // Метод умножения дробей
        public static Fraction operator * (Fraction a, Fraction b)
        {
            Fraction t = new Fraction(1, 1);
            t.numerator = (a.numerator * b.numerator);
            t.denominator = a.denominator * b.denominator;
            return t;
        }

        // Метод деления дробей
        public static Fraction operator / (Fraction a, Fraction b)
        {
            Fraction t = new Fraction(1, 1);
            int temp = b.numerator;
            b.numerator = b.denominator;
            b.denominator = temp;
            t.numerator = (a.numerator * b.numerator);
            t.denominator = a.denominator * b.denominator;
            return t;
        }
    }
}
