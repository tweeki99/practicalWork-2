using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine();

            Console.WriteLine("Введите X");

            double number;
            number = double.Parse(Console.ReadLine());

            double resultFormula = 7 * number * number - 3 * number + 4;
            Console.WriteLine(resultFormula);



            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine();


            Console.WriteLine("Введите радиус");
            double radius = double.Parse(Console.ReadLine());


            double diameter = 2 * radius;

            Console.WriteLine("Радиус: " + (Math.PI * diameter));

            double square = radius * radius * Math.PI;
            Console.WriteLine("Площадь: " + square);



            Console.WriteLine();
            Console.WriteLine("Задание 3");
            Console.WriteLine();


            Console.WriteLine("Введите количество сантиметров");
            int centimeters = int.Parse(Console.ReadLine());


            int centimetersInMeters = 100;
            int meters = centimeters / centimetersInMeters;

            Console.WriteLine("Полных метров: " + meters);



            Console.WriteLine();
            Console.WriteLine("Задание 4");
            Console.WriteLine();


            Console.WriteLine("Введите количество дней");
            int days = int.Parse(Console.ReadLine());


            int daysInWeek = 7;
            int week = days / daysInWeek;

            Console.WriteLine("Прошло недель: " + week);



            Console.WriteLine();
            Console.WriteLine("Задание 5");
            Console.WriteLine();


            Console.WriteLine("Введите двузначное число");
            int numbers = int.Parse(Console.ReadLine());


            int onesInTens = 10;
            int tens = numbers / onesInTens;
            int ones = numbers - tens * onesInTens;

            Console.WriteLine("Десятков: " + tens);
            Console.WriteLine("Единиц: " + ones);
            Console.WriteLine("Сумма цифр: " + (ones + tens));
            Console.WriteLine("Произведение цифр: " + ones * tens);



            Console.WriteLine();
            Console.WriteLine("Задание 6");
            Console.WriteLine();


            Console.WriteLine("Введите четырехзначное  число");
            string fourDigitNumber = Console.ReadLine();

            int summ = 0;
            int multiplication = 1;

            for (int i = 0; i < fourDigitNumber.Length; i++)
            {
                summ += fourDigitNumber[i] - 48;
                multiplication *= fourDigitNumber[i] - 48;
            }

            Console.WriteLine("Сумма: " + summ);
            Console.WriteLine("Произведение: " + multiplication);



            Console.WriteLine();
            Console.WriteLine("Задание 7");
            Console.WriteLine();


            Console.WriteLine("Введите образованное трехзначное  число");
            string threeDigitNumber = Console.ReadLine();

            string originalThreeDigitNumber = null;
            originalThreeDigitNumber += threeDigitNumber[0];
            originalThreeDigitNumber += threeDigitNumber[2];
            originalThreeDigitNumber += threeDigitNumber[1];

            Console.WriteLine("Начальное число: " + originalThreeDigitNumber);



            Console.WriteLine();
            Console.WriteLine("Задание 8");
            Console.WriteLine();


            bool X = true, Y = true;
            int quantitiesExpressed = 3;
            int quantitiesPossibleOptions = 4;
            for (int j = 0; j < quantitiesExpressed; j++)
            {
                switch (j)
                {
                    case 0:
                        Console.WriteLine("не X и не Y");
                        Console.WriteLine("---------------------");
                        break;
                    case 1:
                        Console.WriteLine("X или (не X и Y)");
                        Console.WriteLine("---------------------");
                        break;
                    case 2:
                        Console.WriteLine("(не X и Y) или Y");
                        Console.WriteLine("---------------------");
                        break;
                }
                for (int i = 0; i < quantitiesPossibleOptions; i++)
                {
                    int lastIteration = 3;
                    switch (i)
                    {
                        case 0:
                            X = true; Y = true;
                            break;
                        case 1:
                            X = false; Y = false;
                            break;
                        case 2:
                            X = false; Y = true;
                            break;
                        case 3:
                            X = true; Y = false;
                            break;
                    }
                    if (j == 0)
                    {
                        Console.WriteLine("X: " + X + " Y: " + Y);
                        if (!X && !Y)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        if (i == lastIteration)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("X: " + X + " Y: " + Y);
                        if (X || (!X && Y))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        if (i == lastIteration)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("X: " + X + " Y: " + Y);
                        if ((!X && Y) || Y)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                    }
                }
            }

           
            Console.ReadLine();
        }
    }
}
