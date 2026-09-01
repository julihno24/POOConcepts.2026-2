namespace GeometricFigures.Backend
{
    public class Rectangle : Square
    {
        protected double _b;

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        protected double ValidateB(double b)
        {
            if (b <= 0) throw new ArgumentException("Side B must be greater than zero.");
            return b;
        }

        public override double GetArea() => _a * _b;

        public override double GetPerimeter() => 2 * (_a + _b);
    }
}
