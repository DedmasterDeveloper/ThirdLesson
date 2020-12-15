using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    /*
     * Задание:
     * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
     * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
     */
    class Complex
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        //private double _re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double _im;

        /// <summary>
        /// Свойство Re для поля re
        /// </summary>
        public double Re { get; set; }

        public double Im
        {
            get { return _im; }
            set
            {
                if (value > 0)
                    _im = value;
                else
                    throw new Exception("Мнимая часть комплексного числа должна быть > 0");
            }
        }

        public Complex(double re, double im)
        {
            Re = re;

            if (im > 0)
                this._im = im;
            else
                throw new Exception("Мнимая часть комплексного числа должна быть > 0");
        }

        public Complex()
        {

        }

        public Complex Plus(Complex x)
        {
            Complex y = new Complex();
            y.Re = Re + x.Re;
            y._im = _im + x._im;
            return y;
        }

        public Complex Minus (Complex x)
        {
            Complex y = new Complex();
            y.Re = Re - x.Re;
            y._im = _im - x._im;
            return y;
        }

        public Complex Multiplication(Complex x)
        {
            Complex y = new Complex();
            y.Re = Re * x.Re;
            y._im = _im * x._im;
            return y;
        }

        public override string ToString()
        {
            return $"{Re} + {_im}i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complexFirst = new Complex();
            complexFirst.Re = 10;
            complexFirst.Im = 2;
            Complex complexSecond = new Complex(23, 5);
            Console.WriteLine($"Комплексные числа: {complexFirst} и {complexSecond}");
            Console.WriteLine($"Сложение комплексных чисел: {complexFirst.Plus(complexSecond)}");
            Console.WriteLine($"Вычитание комплексных чисел: {complexFirst.Minus(complexSecond)}");
            Console.WriteLine($"Произведение комплексных чисел: {complexFirst.Multiplication(complexSecond)}");
            Console.ReadLine();
        }
    }
}
