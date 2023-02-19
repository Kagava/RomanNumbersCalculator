using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    internal class RomanNumber : IComparable, ICloneable
    {
        private ushort number = 1;
        private string romanNumber = string.Empty;
        public RomanNumber(ushort number)
        {
           if (number < 1 || number > 3999) throw new RomanNumberException("#ERROR");
            string[] rim_numbers = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I", " " };
            ushort[] numbers_array = new ushort[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1, 0 };
            this.number = number;
            string StringRoman = string.Empty;
            int counter = 0;
            while (number > 0)
            {
                while (numbers_array[counter] <= number)
                {
                    StringRoman += rim_numbers[counter];
                    number -= numbers_array[counter];
                }
                counter++;
            }
            romanNumber = StringRoman;
        }
        private ushort Dic(char input)
        {
            ushort output = 0;
            string I = "I";
            string V = "V";
            string X = "X";
            string L = "L";
            string C = "C";
            string D = "D";
            string M = "M";
            if (input == I.ToCharArray()[0]) output = 1;
            if (input == V.ToCharArray()[0]) output = 5;
            if (input == X.ToCharArray()[0]) output = 10;
            if (input == L.ToCharArray()[0]) output = 50;
            if (input == C.ToCharArray()[0]) output = 100;
            if (input == D.ToCharArray()[0]) output = 500;
            if (input == M.ToCharArray()[0]) output = 1000;
            return output;
        }
        public RomanNumber(string number)
        {
            romanNumber = number;
            if (number.Length == 1) this.number = Dic(number[0]);
            else
            {
                ushort result = 0, i = 0;
                while (i < number.Length - 1)
                {
                    if (Dic(number[i]) < Dic(number[i+1]))
                    {
                        result += (ushort)(Dic(number[i+1]) - Dic(number[i]));
                        i += 2;
                    }
                    else
                    {
                        result += Dic(number[i]);
                        i++;
                        if (i == number.Length - 1)
                            result += Dic(number[i]);
                    }
                }
                this.number = result;
            }
            if (number != new RomanNumber(this.number).ToString()) throw new RomanNumberException("#ERROR");
            if (this.number < 1 || this.number > 3999) throw new RomanNumberException("#ERROR");
        }
        public static RomanNumber Add(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number + RomanNumber2.number));
        }
        public static RomanNumber Sub(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number - RomanNumber2.number));
        }
        public static RomanNumber Mul(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number * RomanNumber2.number));
        }
        public static RomanNumber Div(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.number / RomanNumber2.number));
        }
        public override string ToString() => romanNumber;
        public ushort ToUInt16() => number;
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
