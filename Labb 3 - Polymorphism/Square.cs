namespace Labb_3___Polymorphism
{
    internal class Square : Geometry
    {
        public double Length { get; set; }
        public Square()
        {
            Length = 3;
            name = "Square";
        }
        public override double Area()
        {
            double area = Length * Length;
            double sum = Math.Round(area, 2);
            return sum; 
        }
    }
}
