namespace lab12

{
    internal class Complex
    {
        public double Re;
        public double Im;

        public Complex(double Re, double Im)
        {
            this.Re = Re;
            this.Im = Im;
        }

        public override string ToString()
        {
            double a = Re, y = Im;
            if (y == 0)
            {
                return $"{a}";
            }
            else if (y > 0)
            {
                return $"{a} + {y}i";
            }
            else
            {
                return $"{a} - {-y}i";
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                return Re == (obj as Complex).Re && Im == (obj as Complex).Im;
            }
            else if (Im == 0 && double.TryParse(obj.ToString(), out double number))
            {
                return Re == number;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Complex x, Complex y)
        {
            return x.Re == y.Re && x.Im == y.Im;
        }

        public static bool operator !=(Complex x, Complex y)
        {
            return !(x.Re == y.Re && x.Im == y.Im);
        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(x.Re + y.Re, x.Im + y.Im);
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(x.Re - y.Re, x.Im - y.Im);
        }

        public static Complex operator *(Complex x, Complex y)
        {
            return new Complex(x.Re * y.Re - x.Im * y.Im,
                x.Re * y.Im + x.Im * y.Re);
        }
    }
}