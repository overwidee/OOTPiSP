namespace example6
{
    public interface INumber
    {
        INumber Add(INumber number);
        INumber Subtract(INumber number);
        INumber Multiply(INumber number);
        INumber Divide(INumber number);
    }

    public class Rational : INumber
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public Rational(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public int GetX() => _numerator;
        public int GetY() => _denominator;

        public INumber Add(INumber number)
        {
            var n = ((Rational) number).GetX();
            var d = ((Rational) number).GetY();
            return new Rational(_numerator * d + _denominator * n,
                _denominator * d);
        }

        public INumber Subtract(INumber number)
        {
            var n = ((Rational) number).GetX();
            var d = ((Rational) number).GetY();
            return new Rational(_numerator * d - _denominator * n,
                _denominator * d);
        }

        public INumber Multiply(INumber number)
        {
            return new Rational(_numerator * ((Rational) number).GetX(),
                _denominator * ((Rational) number).GetY());
        }

        public INumber Divide(INumber number)
        {
            return new Rational(_numerator * ((Rational) number).GetY(),
                _denominator * ((Rational) number).GetX());
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
    }
}