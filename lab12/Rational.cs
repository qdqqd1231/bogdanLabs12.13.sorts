using System;

namespace lab12
{
    internal class Rational
    {
        //числитель и знаменатель
        public int numerator { get; set; }
        public int denominator { get; set; }
        private static int NOD(int a, int b)
        {
            if (b < 0)
                b = -b;
            if (a < 0)
                a = -a;
            while(b>0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static int NOK(int a, int b)
        {
            return Math.Abs(a * b) / NOD(a, b);
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
            int nok = NOK(x.denominator, y.denominator);
            if (x.numerator*(nok/x.denominator) == y.numerator*(nok/y.denominator))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator !=(Rational x, Rational y)
        {
            return !(x==y);
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
            if (x.numerator * y.denominator - x.denominator * y.numerator == 0)
            {
                return new Rational(0, 0);
            }
            else
            {
                return new Rational(x.numerator * y.denominator - x.denominator * y.numerator, x.denominator * y.denominator);
            }
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
