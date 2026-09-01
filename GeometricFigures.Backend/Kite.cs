namespace GeometricFigures.Backend
{
    public class Kite : Rhombus
    {
        private double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            B = b;
        }

        private double ValidateB(double b)
        {
            if (b <= 0) throw new ArgumentException("Side B must be greater than zero.");
            return b;
        }

        public override double GetArea() => (_d1 * _d2) / 2;

        public override double GetPerimeter() => 2 * (_a + _b);
    }
}