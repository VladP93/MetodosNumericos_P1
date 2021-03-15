using System;

namespace _1_Biseccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Método de la bisección");
            Console.WriteLine("Ecuación -> sen(x) +2x - 1 = 0");
            Console.WriteLine("Intérvalos: [-2,2]");
            Console.WriteLine("Error: 10^(-3) = 0.001");
            for(int i=0;i<12;i++){
                Console.Write("*-*-*-");
            }
            Console.WriteLine("");

            double a = -2;
            double b = 2;
            double errorAdmitido = 0.001;
            double err = 0;
            double xr=(a+b)/2;
            double xrAnterior=0;
            double Fa = (Math.Sin(a)) + (2*a) - 1;
            double Fxr = (Math.Sin(xr)) + (2*xr) - 1;
            double FaFxr = Fa*Fxr;
            do{
                xrAnterior = xr;
                if(!(FaFxr<0)){
                    a = xr;
                }
                if(!(FaFxr>0)){
                    b=xr;
                }

                xr = (a+b)/2;
                Fa = (Math.Sin(a)) + (2*a) - 1;
                Fxr =  (Math.Sin(xr)) + (2*xr) - 1;
                FaFxr = Fa*Fxr;

                err=Math.Abs((xr-xrAnterior)/xr) * 100;
                Console.WriteLine("Error: " + err);
            }while(err>errorAdmitido);

            Console.WriteLine("El valor de XR es igual a: "+xrAnterior);

        }
    }
}
