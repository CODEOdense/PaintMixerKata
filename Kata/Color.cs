﻿using System;

namespace Kata
{
    public class Color
    {
        public readonly ColorValue R;
        public readonly ColorValue G;
        public readonly ColorValue B;

        public Color(ColorValue r, ColorValue g, ColorValue b)
        {
            R = r;
            G = g;
            B = b;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Color;
            return other != null &&
                other.R.Equals(R) &&
                other.G.Equals(G) &&
                other.B.Equals(B);
        }

        public override int GetHashCode()
        {
            return R + G + B;
        }

        public override string ToString()
        {
            return $"(R: {R}, G: {G}, B: {B})";
        }

        public static Color operator +(Color a, Color b)
        {
            return Mixer.Mix(a, b);
        }

        
        public static Color MakeSomeRed()
        {
            return new Color(200, 0, 0);
        }

        public static Color MakeSomeGreen()
        {
            return new Color(0, 200, 0);
        }
        public static Color MakeSomeBlue()
        {
            return new Color(0, 0, 200);
        }
    }

   
}
