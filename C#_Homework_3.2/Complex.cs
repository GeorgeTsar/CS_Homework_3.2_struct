using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework_3._2
{
    struct Complex
    {
        public int first;
        public int second;
        public Complex(int f, int s)
        {
            first = f;
            second = s;
        }

        // Вывод комплексного числа (в виде строки)
        public override string ToString()
        {
            return first.ToString() + " + " + second.ToString() + "i";
        }

        // Метод сложения комплексных чисел
        public static Complex operator + (Complex a, Complex b)
        {
            Complex t = new Complex(1, 1);
            t.first = a.first + b.first;
            t.second = a.second + b.second;
            return t;
        }

        // Метод вычитания комплексных чисел
        public static Complex operator - (Complex a, Complex b)
        {
            Complex t = new Complex(1, 1);
            t.first = a.first - b.first;
            t.second = a.second - b.second;
            return t;
        }

        // Метод умножения комплексных чисел
        public static Complex operator * (Complex a, Complex b)
        {
            Complex t = new Complex(1, 1);
            t.first = a.first * a.second - b.first * b.second;
            t.second = a.first * b.second - a.second * b.first;
            return t;
        }

        // Метод деления комплексных чисел
        public static Complex operator / (Complex a, Complex b)
        {
            Complex t = new Complex(1, 1);
            t.first = (a.first + b.first) * (a.second - b.second);
            t.second = (a.second + b.second) * (a.second - b.second);
            return t;
        }

    }
}
