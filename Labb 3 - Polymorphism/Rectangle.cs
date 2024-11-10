namespace Labb_3___Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Rectangle()
        {
            Base = 3;
            Height = 5;
            name = "Rectangle";
        }
        public override double Area()
        {
            double area = Base * Height;
            double sum = Math.Round(area, 2);
            return sum;
        }
    }
}
