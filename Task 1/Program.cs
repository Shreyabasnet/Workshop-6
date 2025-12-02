class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle
        {
            Length = 10,
            Breadth = 5
        };

        Console.WriteLine(rect.ShowDetails());
        Console.WriteLine("Area: " + rect.GetArea());
        Console.WriteLine("Perimeter: " + rect.GetPerimeter());
    }
}