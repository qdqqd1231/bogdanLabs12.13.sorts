using System;

namespace lab12
{
    internal class Rational
    {
        //числитель и знаменатель
        public int numerator { get; set; }
        public int denominator { get; set; }
        private static int NOZ(int[] maxmin)
        {
            Array.Sort(maxmin);
            if (maxmin[1] % maxmin[0] == 0)
            {
                return maxmin[1];
            }

            int temp = 0;
            for (int i = 2; ; i++)
            {
                temp = maxmin[1] * i;
                if (temp % maxmin[0] == 0)
                {
                    break;
                }
            }
            return temp;
        }

        public Rational(int numerator, int denominator)
        {
            if (denominator <= 0)
            {
                throw new Exception("Does not valid denominator value.");
            }
            else
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
        }
        public static bool operator ==(Rational x, Rational y)
        {
            return x.numerator == y.numerator && x.denominator == y.denominator;
        }

        public static bool operator !=(Rational x, Rational y)
        {
            return !(x.numerator == y.numerator && x.denominator == y.denominator);
        }

        public override bool Equals(object obj)
        {
            if (decimal.TryParse(obj.ToString(), out decimal number))
            {
                return Convert.ToDecimal(numerator) / denominator == number;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public static bool operator <(Rational x, Rational y)
        {
            return x.numerator * y.denominator < x.denominator * y.numerator;
        }

        public static bool operator >(Rational x, Rational y)
        {
            return x.numerator * y.denominator > x.denominator * y.numerator;
        }

        public static bool operator <=(Rational x, Rational y)
        {
            return x.numerator * y.denominator <= x.denominator * y.numerator;
        }

        public static bool operator >=(Rational x, Rational y)
        {
            return x.numerator * y.denominator >= x.denominator * y.numerator;
        }

        public static Rational operator +(Rational x, Rational y)
        {
            return new Rational(x.numerator * y.denominator + x.denominator * y.numerator, x.denominator * y.denominator);
        }

        public static Rational operator -(Rational x, Rational y)
        {
            return new Rational(x.numerator * y.denominator - x.denominator * y.numerator, x.denominator * y.denominator);
        }

        public static Rational operator *(Rational x, Rational y)
        {
            return new Rational(x.numerator * y.numerator, x.denominator * y.denominator);
        }

        public static Rational operator /(Rational x, Rational y)
        {
            return new Rational(x.numerator * y.denominator, x.denominator * y.numerator);
        }

        public static Rational operator %(Rational x, Rational y)
        {
            return x - (Rational)(int)(x / y) * y;
        }

        public static Rational operator ++(Rational x)
        {
            return new Rational(x.numerator + x.denominator, x.denominator);
        }

        public static Rational operator --(Rational x)
        {
            return new Rational(x.numerator - x.denominator, x.denominator);
        }

        public static explicit operator Rational(int x)
        {
            return new Rational(x, 1);
        }

        public static explicit operator float(Rational x)
        {
            return Convert.ToSingle(x.numerator) / x.denominator;
        }

        public static explicit operator int(Rational x)
        {
            return x.numerator / x.denominator;
        }




    }
}
