namespace Labb_3___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // skapar objektreferenser från geometry-klassen och låter den peka på varje underklass
            Geometry circle = new Circle();
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();

            // skapar en list som går igenom objektreferenserna och anropar area metoden i foreach loopen.
            List<Geometry> Areas = new List<Geometry>{circle, rectangle, square};
            // går igenom list och skriver ut den rätta arean av varje objektreferens genom polymorfism
            foreach (Geometry Shape in Areas)
            {
                Console.WriteLine($"Area of {Shape.name}: {Shape.Area()}");
            }
        }
    }
}
