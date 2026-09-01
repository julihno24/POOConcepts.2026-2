namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public override string Name { get; }

        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }

        private double ValidateR(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("The radius must be greater than zero.");
            }
            return r;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_r, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _r;
        }
    }
}