class Rectange
{
   public double With; 
   public double Height; 
   public string Color; 


   public double GetArea()
   {
    double areaOfCirle;
    areaOfCirle = With*Height;
    return areaOfCirle;
   }
   
   public double  GetPerimeter ()
   {
    double perimetr;
    perimetr = 2 *( With + Height);
    return perimetr;

   }
   
}
class Circle
{
   public const double pi =3.14;
   public double Radius;
   public double color;
    public double  GetCircumference()
    {
        double circum;
        circum = 2*pi*Radius;
        return circum;      
    }
    public double GetAreasr()
    {
        double areasr;
        areasr  = pi*Radius*Radius;
        return areasr;
    }
}

class Shape
{  
   public string Name ="Restange"; 
   public string color = "Green"; 
   public int PositionX = 5;  
   public int PositionY = 15;  
   public void GetPosition()
   {
    System.Console.WriteLine();
    System.Console.WriteLine("_____________");
    System.Console.WriteLine($"PositionX =  {PositionX} ");
    System.Console.WriteLine($"PositionY = {PositionY}");
   }
   public void Getinfo(){
    System.Console.WriteLine("_____________");
    System.Console.WriteLine($"name= {Name} \ncolor=  {color}\n{PositionX}-{PositionY}");

   }
 
}