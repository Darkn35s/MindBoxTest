
namespace MindBoxTest
{
    public class Circle : IFigure
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(r,2);
        }
    }
}
