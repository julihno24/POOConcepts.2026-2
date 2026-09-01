namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        protected double _c;
        protected double _h;

        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        protected double ValidateC(double c)
        {
            if (c <= 0) throw new ArgumentException("Side C must be greater than zero.");
            return c;
        }

        protected double ValidateH(double h)
        {
            if (h <= 0) throw new ArgumentException("Height H must be greater than zero.");
            return h;
        }

        public override double GetArea() => (_b * _h) / 2;

        public override double GetPerimeter() => _a + _b + _c;
    }
}