using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework_3._2
{
    struct Birthday
    {
        public int day;
        public int month;
        public int year;
        public Birthday(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }

        // Вывод даты Дня рождения (в виде строки)
        public override string ToString()
        {
            return day.ToString() + "." + month.ToString() + "." + year.ToString();
        }
        
        // Определение дня недели, когда родился человек
        public string DayOfWeek (Birthday a)
        {
            int cm;
            if (a.month == 1)
            {
                cm = 1;
            }
            else if (a.month == 2)
            {
                cm = 4;
            }
            else if (a.month == 3)
            {
                cm = 4;
            }
            else if (a.month == 4)
            {
                cm = 0;
            }
            else if (a.month == 5)
            {
                cm = 2;
            }
            else if (a.month == 6)
            {
                cm = 5;
            }
            else if (a.month == 7)
            {
                cm = 0;
            }
            else if (a.month == 8)
            {
                cm = 3;
            }
            else if (a.month == 9)
            {
                cm = 6;
            }
            else if (a.month == 10)
            {
                cm = 1;
            }
            else if (a.month == 11)
            {
                cm = 4;
            }
            else
            {
                cm = 6;
            }

            int by = a.year % 100;
            int cy = (6 + by + by / 4) % 7;
            int dw = (a.day + cm + cy) % 7;

            if (dw == 0)
            {
                return "Суббота";
            }
            else if (dw == 1)
            {
                return "Воскресенье";
            }
            else if (dw == 2)
            {
                return "Понедельник";
            }
            else if (dw == 3)
            {
                return "Вторник";
            }
            else if (dw == 4)
            {
                return "Среда";
            }
            else if (dw == 5)
            {
                return "Четверг";
            }
            else
            {
                return "Пятница";
            }
        }

        // Определение дня недели в указанном году
        public string DayOfWeekThisYear(Birthday a, int b)
        {
            int cm;
            if (a.month == 1)
            {
                cm = 1;
            }
            else if (a.month == 2)
            {
                cm = 4;
            }
            else if (a.month == 3)
            {
                cm = 4;
            }
            else if (a.month == 4)
            {
                cm = 0;
            }
            else if (a.month == 5)
            {
                cm = 2;
            }
            else if (a.month == 6)
            {
                cm = 5;
            }
            else if (a.month == 7)
            {
                cm = 0;
            }
            else if (a.month == 8)
            {
                cm = 3;
            }
            else if (a.month == 9)
            {
                cm = 6;
            }
            else if (a.month == 10)
            {
                cm = 1;
            }
            else if (a.month == 11)
            {
                cm = 4;
            }
            else
            {
                cm = 6;
            }

            int y = b % 100;
            int cy = (6 + y + y / 4) % 7;
            int dw = (a.day + cm + cy) % 7;

            if (dw == 0)
            {
                return "Суббота";
            }
            else if (dw == 1)
            {
                return "Воскресенье";
            }
            else if (dw == 2)
            {
                return "Понедельник";
            }
            else if (dw == 3)
            {
                return "Вторник";
            }
            else if (dw == 4)
            {
                return "Среда";
            }
            else if (dw == 5)
            {
                return "Четверг";
            }
            else
            {
                return "Пятница";
            }
        }

        // Определение количества дней до Дня рождения
        public int DaysToBirthday(Birthday a, int CurrDay, int CurrMonth)
        {
            int Tm, Td = 0;

            if (a.month > CurrMonth)
            {
                Tm = a.month - CurrMonth;
            }
            else
            {
                Tm = CurrMonth - a.month;
            }

            Tm = Tm * 30;
            Td = Tm + CurrDay;

            return Td;
        }
    }
}