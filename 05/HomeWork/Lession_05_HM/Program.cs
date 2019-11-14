using System;

namespace Lession_05_HM
{
    class Program
    {
        enum Firgure : byte
        {
            Сircle = 1,    // Каждый следующий элемент ++
            Triangle,
            Rectangle
        }
        static void Main(string[] args)
        {
            Start:
            static void Circle()
            {
                StartSircle:
                Console.WriteLine("Введите диаметр D:");
                try
                {
                    string D1 = Console.ReadLine();
                    D1 = D1.Replace(".", ",");
                    double D = double.Parse(D1);
                    if (D > 0)
                    {
                        double S = Math.Round((Math.Pow((D / 2), 2) * Math.PI), 2);
                        Console.WriteLine($"Площадь круга равна {S}");

                        double C = Math.Round(((D / 2) * Math.PI * 2), 2);
                        Console.WriteLine($"Длина периметра равна {C}");
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка! Вы ввели ноль или отрицательное значение.\nЧтобы вернуться к вводу, нажмите любую клавишу.");
                        Console.ReadKey();
                        Console.Clear();
                        goto StartSircle;
                    }
                    
                }
                catch
                {
                    Console.WriteLine($"Вы ввели нечисловое значение.\nЧтобы вернуться к вводу, нажмите любую клавишу.");
                    Console.ReadKey();
                    Console.Clear();
                    goto StartSircle;
                }
            }
            static void Triangle()
            {
                StartTriangle:
                Console.WriteLine($"Введите длину стороны L:");
                try
                {
                    string L1 = Console.ReadLine();
                    L1 = L1.Replace(".", ",");
                    double L = double.Parse(L1);
                    if (L > 0)
                    {
                        double p = (L + L + L) / 2;
                        Console.WriteLine($"Длина периметра равна {p}");
                        double S = Math.Sqrt(p * (p - L) * (p - L) * (p - L));
                        Console.WriteLine($"Площадь равна {S}");
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка! Вы ввели ноль или отрицательное значение.\nЧтобы вернуться к вводу, нажмите любую клавишу.");
                        Console.ReadKey();
                        Console.Clear();
                        goto StartTriangle;
                    }
                    
                }
                catch
                {
                    Console.WriteLine($"Вы ввели нечисловое значение.\nЧтобы вернуться к вводу, нажмите любую клавишу.");
                    Console.ReadKey();
                    Console.Clear();
                    goto StartTriangle;
                }
                
            }
            static void Rectangle()
            {
                StartRectangle:
                try
                {
                    Console.WriteLine($"Введите высоту H:");
                    string W1 = Console.ReadLine();
                    W1 = W1.Replace(".", ",");
                    double W = double.Parse(W1);

                    Console.WriteLine($"Введите ширину W:");
                    string H1 = Console.ReadLine();
                    H1 = H1.Replace(".", ",");
                    double H = double.Parse(H1);

                    if (H > 0 && W > 0)
                    {
                        double S = Math.Round((H * W), 2);
                        Console.WriteLine($"Площадь равна {S}");
                        double p = Math.Round(((H + W) * 2), 2);
                        Console.WriteLine($"Длина периметра равна {p}");
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка! Вы ввели ноль или отрицательное значение.\nЧтобы вернуться к вводу, нажмите любую клавишу.");
                        Console.ReadKey();
                        Console.Clear();
                        goto StartRectangle;
                    }

                }
                catch
                {
                    Console.WriteLine($"Вы ввели нечисловое значение.\nЧтобы вернуться к вводу, нажмите любую клавишу.");
                    Console.ReadKey();
                    Console.Clear();
                    goto StartRectangle;
                }
            }
            Console.WriteLine("Ввыберите фигуру:\n1 - Круг\n2 - Равносторонний треугольник\n3 - Прямоугольник");
            try
            {
                double FigureSelect = double.Parse(Console.ReadLine());
                if (FigureSelect > 0)
                {
                    switch (FigureSelect)
                    {
                        case (double)Firgure.Сircle:
                            Console.WriteLine("Выбран Круг.");
                            Circle();
                            break;
                        case (double)Firgure.Triangle:
                            Console.WriteLine("Выбран Равносторонний треугольник.");
                            Triangle();
                            break;
                        case (double)Firgure.Rectangle:
                            Console.WriteLine("Выбран Прямоугольник.");
                            Rectangle();
                            break;
                        /*case (double)Firgure.Test:
                            Console.WriteLine("Выбран ТЕСТ.");
                            string D1 = Console.ReadLine();
                            D1 = D1.Replace(".",",");
                            double D = double.Parse(D1);
                            Console.WriteLine($"D1 = {D1}\nD = {D}");
                            break;*/
                        default:
                            Console.WriteLine("Такой фигуры не существует. Выберите другую.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Ошибка! Вы ввели ноль или отрицательное значение.\nЧтобы вернуться к выбору фигуры, нажмите любую клавишу.");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                }

            }
            catch
            {
                Console.WriteLine("Вы ввели нечисловое значение!");
            }
            Console.WriteLine("\nКонец программы\nЧтобы вернуться в начало, нажмите любую клавишу.");
            Console.ReadKey();
            Console.Clear();
            goto Start;
        }
    }
}
