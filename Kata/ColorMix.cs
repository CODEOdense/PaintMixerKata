using System;

namespace Kata
{
    class Mixer
    {

        public static Color Mix(Color a, Color b)
        {
            return Mix(new Paint(a, 1), new Paint(b, 1)).Color;
        }

        public static Paint Mix(Paint a, Paint b)
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
    }
}
