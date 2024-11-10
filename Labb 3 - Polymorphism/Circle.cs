namespace Labb_3___Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 4;
            name = "Circle";  // används för utskriften 
        }
        public override double Area()
        {
            double area = Math.PI * Radius * Radius; //A = π r²
            double sum = Math.Round(area, 2); // används för att avrunda aren till 2 decimaler
            return sum;  
        }
    }
}
