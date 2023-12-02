

namespace effectiveMethod.Service
{
    class ForResult
    {
        public int EKUB;
        public int X;
        public int Y;
    }
    internal class ExtendedEuclideanAlgorithm
    {
        //a*X+b*Y=EKUB(a,b) we need a ham b
        public static ForResult CALC(int a,int b)
        {
            if (b == 0)
            {
                return new ForResult { EKUB=a,X=1,Y=0};
            }

            ForResult oldResult = CALC(b, a % b);
            return new ForResult { 
                EKUB = oldResult.EKUB,
                X = oldResult.Y, 
                Y = oldResult.X - (a / b) * oldResult.Y
            };
        }
    }
}
