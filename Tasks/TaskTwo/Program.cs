using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    /*
     * Задание:
     * а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
     * б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
     */
    class ActionsWithNumbers
    {
        private static int _sum;
        private int _inputNumber;
        public int inputNumber
        {
            get { return _inputNumber; }
            set
            {
                _inputNumber = value;
                if (_inputNumber % 2 != 0 && _inputNumber > 0)
                {
                    _sum += _inputNumber;
                }
            }
        }
        public ActionsWithNumbers()
        {

        }
        public ActionsWithNumbers(int number)
        {
            _inputNumber = number;
            if(_inputNumber % 2 != 0 && _inputNumber > 0)
            {
                _sum += _inputNumber;
            }
        }

        public int Sum()
        {
            return _sum;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите с клавиатуры числа, для завершения введите (0).");
            ActionsWithNumbers actionsWithNumbers = new ActionsWithNumbers();
            while (true)
            {
                bool checkingTheNumber = int.TryParse(Console.ReadLine(), out int number);
                if(checkingTheNumber)
                {
                    if (number == 0)
                    {
                        break;
                    }
                    else
                    {
                        actionsWithNumbers.inputNumber = number;
                    }
                }
                else
                    Console.WriteLine("Вы ввели не коректное число.");
                
            }

            Console.WriteLine($"Сумма нечетных положительных чисел: {actionsWithNumbers.Sum()} ");
            Console.WriteLine("Для завершения нажмите Enter");
            Console.ReadLine();
        }
    }
}
