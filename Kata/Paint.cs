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
            return Mixer.Mix(a, b);
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
