namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        public abstract string Name { get; }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name,-15} => Area.....: {GetArea(),10:N5}    Perimeter: {GetPerimeter(),10:N5}";
        }
    }
}