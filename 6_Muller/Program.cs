using System;

namespace _6_Muller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metodo de Muller");
            Console.WriteLine("f(x) = x^4 - 3x^3 + x^2 + x + 1");
            Console.WriteLine("h0 = x1 - x0");
            Console.WriteLine("h1 = x2 - x1");
            Console.WriteLine("sig0 = f(x1) - f(x0) / x1 - x0");
            Console.WriteLine("sig1 = f(x2) - f(x1) / x2 - x1");
            Console.WriteLine("x2 + (-2c)/b +- sqrt(b^2 - 4ac)");
            Console.WriteLine("a = ((sig1 - sig0)/(h1 - h0))");
            Console.WriteLine("b = ah1 + sig1");
            Console.WriteLine("c = f(x2)");
            for(int i=0;i<12;i++){
                Console.Write("*-*-*-");
            }
            Console.WriteLine("");

            double x0 = 1;
            double x1 = 2;
            double x2 = (x0+x1)/2;
            double Fx0 = Math.Pow(x0,4) - 3*Math.Pow(x0,3) + Math.Pow(x0,2) + x0 + 1;
            double Fx1 = Math.Pow(x1,4) - 3*Math.Pow(x1,3) + Math.Pow(x1,2) + x1 + 1;
            double Fx2 = Math.Pow(x2,4) - 3*Math.Pow(x2,3) + Math.Pow(x2,2) + x2 + 1;
            double h0 = x1 - x0;
            double h1 = x2 - x1;
            double sig0 = (Fx1 - Fx0) / h0;
            double sig1 = (Fx2 - Fx1) / h1;
            double a = (sig1 - sig0)/(h1-h0);
            double b = (a*h1) + sig1;
            double c = Fx2;
            double x3=0;
            double err=0;
            double errorAdmitido = 0.001;

            if(b>0){
                x3 = x2 +(-2*c)/(b+(Math.Sqrt(Math.Pow(b,2)-4*a*c)));
            }else{
                x3 = x2 +(-2*c)/(b-(Math.Sqrt(Math.Pow(b,2)-4*a*c)));
            }

            do{
                x0 = x1;
                x1 = x2;
                x2 = x3;
                Fx0 = Math.Pow(x0,4) - 3*Math.Pow(x0,3) + Math.Pow(x0,2) + x0 + 1;
                Fx1 = Math.Pow(x1,4) - 3*Math.Pow(x1,3) + Math.Pow(x1,2) + x1 + 1;
                Fx2 = Math.Pow(x2,4) - 3*Math.Pow(x2,3) + Math.Pow(x2,2) + x2 + 1;
                h0 = x1 - x0;
                h1 = x2 - x1;
                sig0 = (Fx1 - Fx0) / h0;
                sig1 = (Fx2 - Fx1) / h1;
                a = (sig1 - sig0)/(h1-h0);
                b = (a*h1) + sig1;
                c = Fx2;

                if(b>0){
                    x3 = x2 +(-2*c)/(b+(Math.Sqrt(Math.Pow(b,2)-4*a*c)));
                }else{
                    x3 = x2 +(-2*c)/(b-(Math.Sqrt(Math.Pow(b,2)-4*a*c)));
                }

                err = Math.Abs((x3 -x2)/x3)*100;
                Console.WriteLine("Error: "+err);
            }while(err>errorAdmitido);

            Console.WriteLine("El valor de la raíz es: "+x3);
        }
    }
}
