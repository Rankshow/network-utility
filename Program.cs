public class Shape
{
  // ! A few example memebers
  public int X { get; set; } 
  public int Y { get; set; }    
  public int Height { get; set; } 
  public int Width { get; set; }    

  // * Virtual method
  public virtual void Draw()
  {
    Console.WriteLine("Performing badse class drawing tasks");
  }
}
 
 public class Circle : Shape
 {
  // ! code to draw a circle
    public override void Draw()
    {
         Console.WriteLine("Drawing a circle");
         base.Draw();
    }
 }

 public class Rectangle : Shape
 {
  public override void Draw()
  {
       Console.WriteLine("Drawing a Rectangle");
        base.Draw();
  }
 }

 public class Triangle : Shape 
 {
    public override void Draw()
    {
        Console.WriteLine("Drawing Triangle");
        base.Draw();
    }
}
