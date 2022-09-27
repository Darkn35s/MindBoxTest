namespace MindBoxTest
{
    public class TriAngle:IFigure
    {

        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        public TriAngle(double a,double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        
        
        public double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsStraight()
        {
            List<double> ar = new List<double>() {a,b,c};
            ar.Sort();
            if(Math.Pow(ar[0],2)+ Math.Pow(ar[1], 2)== Math.Pow(ar[2], 2))
                return true;
            return false;
        }
    }
}