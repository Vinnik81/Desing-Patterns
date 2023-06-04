Circle circle = new Circle();
circle.radius = 1;
Console.WriteLine(circle.radius);
for (int i = 0; i < 1000; i++)
{
    Console.WriteLine((circle.Clone() as Circle).radius);
}

class Circle : ICloneable
{
    public int radius { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}

//Circle circle = new Circle();
//circle.y = 10;
//circle.x = 20;
//circle.radius = 1;

//Console.WriteLine(circle);
//Console.WriteLine(circle.Clone());



//for (int i = 0; i < 1000; i++)
//{
//    Console.WriteLine(circle.Clone());
//}


//abstract class Shape
//{
//    public int x { get; set; }
//    public int y { get; set; }
//    public string color { get; set; }
//    public abstract Shape Clone();

//    public Shape()
//    {

//    }

//    public Shape(Shape shape)
//    {
//        if (shape != null)
//        {
//            this.x = shape.x;
//            this.y = shape.y;
//            this.color = shape.color;
//        }
//    }
//}

//class Circle: Shape
//{
//    public int radius { get; set; }

//    public Circle()
//    {

//    }

//    public Circle(Circle circle): base(circle)
//    {
//        if (circle != null)
//        {
//            this.radius = circle.radius;
//        }
//    }

//    public override Shape Clone()
//    {
//        return new Circle(this);
//    }

//    public override string? ToString()
//    {
//        return this.y + " " + this.x + " " +this.radius;
//    }
//}

//class Rectangle : Shape
//{
//    public int width { get; set; }
//    public int height { get; set; }

//    public Rectangle()
//    {

//    }


//    public Rectangle(Rectangle rectangle) : base(rectangle)
//    {
//        if (rectangle != null)
//        {
//            this.height = rectangle.height;
//            this.width = rectangle.width;
//        }
//    }

//    public override Shape Clone()
//    {
//        return new Rectangle(this);
//    }
//}