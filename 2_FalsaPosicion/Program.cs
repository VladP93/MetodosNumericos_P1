using System;

namespace _2_FalsaPosicion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Método de la falsa posición");
            Console.WriteLine("Ecuación -> sen(x) +2x - 1 = 0");
            Console.WriteLine("Intérvalos: [-2,2]");
            Console.WriteLine("Error: 10^(-3) = 0.001");
            for(int i=0;i<12;i++){
                Console.Write("*-*-*-");
            }
            Console.WriteLine("");

            double a=-2;
            double b=2;
            double errorAdmitido = 0.001;
            double Fa = (Math.Sin(a)) + (2*a) - 1;
            double Fb = (Math.Sin(b)) + (2*b) - 1;
            double xr = b - ((Fb*(a-b))/(Fa-Fb));
            double Fxr = (Math.Sin(xr)) + (2*xr) - 1;
            double FaFxr = Fa * Fxr;
            double err = 0;
            double xrAnterior = 0;

            do{
                xrAnterior = xr;

                if(!(FaFxr<0)){
                    a = xr;
                }
                if(FaFxr<0){
                    b = xr;
                }

                Fa = (Math.Sin(a)) + (2*a) - 1;
                Fb = (Math.Sin(b)) + (2*b) - 1;
                xr = b - ((Fb*(a-b))/(Fa-Fb));
                Fxr = (Math.Sin(xr)) + (2*xr) - 1;
                FaFxr = Fa * Fxr;
                err = Math.Abs((xr - xrAnterior)/xr * 100);
                Console.WriteLine("Error: " + err);

            }while(err>errorAdmitido);

           Console.WriteLine("El valor de XR es igual a: "+xr);

        }
    }
}
