using System;

namespace _7_Bairstow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metodo Bairstow");
            Console.WriteLine("f(x) = x^4 - 3x^3 + 5x^2 - x - 10");
            Console.WriteLine("bn = an");
            Console.WriteLine("bn-1 = an-1 +rbn");
            Console.WriteLine("bi = ai +rbi+1 + sbi+2");
            Console.WriteLine("cn = bn");
            Console.WriteLine("cn-1 = bn-1 +rcn");
            Console.WriteLine("ci = bi +rci+1 + sci+2");
            Console.WriteLine("deltr = (c3b0 - c2b1)/(c2^2 - c1c3)");
            Console.WriteLine("delts = (c1b1 - c2b0)/(c2^2 - c1c3)");
            Console.WriteLine("x = r +- sqrt(r^2 + 4s) / 2");

            double a0 = -10;
            double a1 = -1;
            double a2 = 5;
            double a3 = -3;
            double a4 = 1;
            double r = -1;
            double s = -1;

            double b4,b3,b2,b1,b0;
            double c4,c3,c2,c1;
            double deltR, deltS;
            double x1,x2;

            do{
                b4 = a4;
                b3 = a3 + (r * b4);
                b2 = a2 + (r * b3) + (s * b4);
                b1 = a1 + (r * b2) + (s * b3);
                b0 = a0 + (r * b1) + (s * b2);

                c4 = b4;
                c3 = b3 + (r * c4);
                c2 = b2 + (r * c3) + (s * c4);
                c1 = b1 + (r * c2) + (s * c3);

                deltR = ((c3 * b0) - (c2 * b1)) / ((Math.Pow(c2,2)) - (c1 * c3));
                deltS = ((c1 * b1) - (c2 * b0)) / ((Math.Pow(c2,2)) - (c1 * c3));

                r += deltR;
                s += deltS;

                Console.WriteLine("delta R: "+deltR+" delta S: "+deltS);

            }while(!(deltR==0 && deltS==0));

            x1 = (r + Math.Sqrt(Math.Pow(r,2) + 4 * s))/2;
            x2 = (r - Math.Sqrt(Math.Pow(r,2) + 4 * s))/2;

            Console.WriteLine("Las raices son:\nRaíz 1 = "+x1+"\nRaíz 2 = "+x2);

        }
    }
}
