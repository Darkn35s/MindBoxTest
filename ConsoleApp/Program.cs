using MindBoxTest;
public class Program
{
    public static void Main()
    {
        TriAngle tr = new TriAngle(4, 3, 6);
        Circle cr = new Circle(5);
            
        List<IFigure> figures = new List<IFigure>();
        figures.Add(tr);
        figures.Add(cr);

        foreach(IFigure f in figures)
        {
            Console.WriteLine(f.GetArea()); 
        }
        Console.WriteLine(tr.IsStraight());


    }
}
