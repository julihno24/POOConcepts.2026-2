namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        protected double _a;

        public override string Name { get; }

        public double A
        {
            get => _a;
            set => _a = ValidateA(value);
        }

        public Square(string name, double a)
        {
            Name = name;
            A = a;
        }

        protected double ValidateA(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Side A must be greater than zero.");
            }
            return a;
        }

        public override double GetArea()
        {
            return Math.Pow(_a, 2);
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }
    }
}