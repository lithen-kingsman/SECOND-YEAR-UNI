using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTrStruct
{
    public struct ComplexTr
    {
        private const double eps = 0.0000000000001;
        private double abs;
        private double arg;
        private readonly double re;
        private readonly double im;

        public double Abs
        {
            get => abs;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Модуль числа не может быть отрицательным");
                abs = value;
            }
        }

        public double Arg { get; set; }
        public double Re => re;
        public double Im => im;


        public ComplexTr(double abs, double arg) : this()
        {
            Abs = abs;
            Arg = arg;
            re = abs * Math.Cos(arg);
            im = abs * Math.Sin(arg);
        }

        public override string ToString()
        {
            if (abs < eps)
            {
                return "0";
            }

            string sign;
            if (im < 0)
            {
                sign = "-";
            }
            else
            {
                sign = "+";
            }

            string reStr = Math.Cos(arg).ToString();
            string imStr = Math.Sin(arg).ToString();

            if (abs == 1)
            {
                return $"{reStr} {sign} i{imStr}";

            }
            else
            {
                return $"{abs} ({reStr} {sign} i{imStr})";
            }
        }
    }
}
