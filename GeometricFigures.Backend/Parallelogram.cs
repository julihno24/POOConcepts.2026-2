namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        private double ValidateH(double h)
        {
            if (h <= 0) throw new ArgumentException("Height H must be greater than zero.");
            return h;
        }

        public override double GetArea() => _b * _h;

        public override double GetPerimeter() => base.GetPerimeter();
    }
}