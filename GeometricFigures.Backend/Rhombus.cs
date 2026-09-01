namespace GeometricFigures.Backend
{
    public class Rhombus : Square
    {
        protected double _d1;
        protected double _d2;

        public double D1
        {
            get => _d1;
            set => _d1 = ValidateD1(value);
        }

        public double D2
        {
            get => _d2;
            set => _d2 = ValidateD2(value);
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        protected double ValidateD1(double d1)
        {
            if (d1 <= 0) throw new ArgumentException("Diagonal 1 must be greater than zero.");
            return d1;
        }

        protected double ValidateD2(double d2)
        {
            if (d2 <= 0) throw new ArgumentException("Diagonal 2 must be greater than zero.");
            return d2;
        }

        public override double GetArea() => (_d1 * _d2) / 2;

        public override double GetPerimeter() => 4 * _a;
    }
}