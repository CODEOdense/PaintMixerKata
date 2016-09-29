using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    /// <summary>
    /// This is the R, G or B values of a color
    /// </summary>
    public class ColorValue
    {
        public readonly int Value;

        public ColorValue(int value)
        {
            if (value < 0 || value > 255)
                throw new ArgumentOutOfRangeException("Color spectrum for RGB is 0->255 strictly");

            Value = value;
        }

        public override bool Equals(object obj)
        {
            var other = obj as ColorValue;

            return other != null && Value.Equals(other.Value);
        }

        public override int GetHashCode()
        {
            return Value;
        }

        public static implicit operator int(ColorValue v)
        {
            return v.Value;
        }

        public static implicit operator ColorValue(int v)
        {
            return new ColorValue(v);
        }

        public override string ToString()
        {
            return Value.ToString();
        }


    }
}
