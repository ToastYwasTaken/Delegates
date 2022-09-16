using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Calculation
    {
        public delegate float CalculationDelegate(float _x, float _y);

        public static float addition(float _summandX, float _summandY)
        {
            return _summandX + _summandY;
        }

        public static float subtraction(float _minuend, float _subtrahend)
        {
            return _minuend - _subtrahend;
        }

        public static float multiplication(float _multiplier, float _multiplicand)
        {
            return _multiplier * _multiplicand;
        }

        public static float division(float _dividend, float _divisor)
        {
            return _dividend / _divisor;
        }

        public static CalculationDelegate ChooseOperation(string _input)
        {
            CalculationDelegate calcDel = null;
            if (_input.Equals("sum"))
            {
                calcDel = new CalculationDelegate(addition);
            }else if (_input.Equals("sub"))
            {
                calcDel = new CalculationDelegate(subtraction);
            }else if (_input.Equals("mul"))
            {
                calcDel = new CalculationDelegate(multiplication);
            }else if (_input.Equals("div"))
            {
                calcDel = new CalculationDelegate(division);
            }
            return calcDel;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose Operation for Calculation: \n[sum] - [sub] - [mul] - [div]");
            CalculationDelegate calcDel = ChooseOperation(Console.ReadLine());

            Console.WriteLine($"Result: {calcDel(1.3f, 1.2f)}");
            Console.ReadLine();
        }
    }
}
