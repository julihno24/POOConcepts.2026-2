namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }

        private double ValidateD(double d)
        {
            if (d <= 0) throw new ArgumentException("Side D must be greater than zero.");
            return d;
        }

        public override double GetArea() => ((_b + _d) * _h) / 2;

        public override double GetPerimeter() => _a + _b + _c + _d;
    }
}