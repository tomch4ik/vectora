using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectora
{
    public struct DecimalNumber
    {
        public int Value { get; set; }
        public DecimalNumber(int value)
        {
            Value = value;
        }
        public string BinaryNumber()
        {
            return Convert.ToString(Value, 2);
        }
        public string OctalNumber()
        {
            return Convert.ToString(Value, 8);
        }
        public string HexadecimalNumber()
        {
            return Convert.ToString(Value, 16).ToUpper();
        }
        public override string ToString()
        {
            return $"DecimalNumber({Value})";
        }
    }
    internal class DecimalNumbers
    {
        static void Main()
        {
            DecimalNumber number = new DecimalNumber(100);
            Console.WriteLine("Двоичная система: " + number.BinaryNumber());
            Console.WriteLine("Восьмеричная система: " + number.OctalNumber());
            Console.WriteLine("Шестнадцатеричная система: " + number.HexadecimalNumber());
        }
    }
}
