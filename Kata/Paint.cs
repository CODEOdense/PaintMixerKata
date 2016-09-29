using System;

namespace Kata
{
    class Paint
    {
        public readonly decimal Volume;
        public readonly Color Color;

        public Paint(Color c, decimal amountML)
        {
            if (!(amountML > 0)) throw new ArgumentOutOfRangeException("No (or negative) amount of paint i not some paint");
            if (c == null) throw new ArgumentNullException("c");


            Color = c;
            Volume = amountML;
        }

        public static Paint operator +(Paint a, Paint b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(b));

            var totalAmount = a.Volume + b.Volume;
            var aFactor = a.Volume / totalAmount;
            var bFactor = b.Volume / totalAmount;

            var c = new Color(
                (int)((a.Color.R * aFactor) + (b.Color.R * bFactor)),
                (int)((a.Color.G * aFactor) + (b.Color.G * bFactor)),
                (int)((a.Color.B * aFactor) + (b.Color.B * bFactor)));

            return new Paint(c, totalAmount);
        }

        public override string ToString()
        {
            return $"{Volume} ml of {Color}";
        }

        public override int GetHashCode()
        {
            return (int)Volume + Color.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as Paint;
            return other != null &&
                other.Volume.Equals(Volume) &&
                other.Color.Equals(Color);
        }
    }
}
