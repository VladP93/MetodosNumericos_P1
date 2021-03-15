using System;

namespace _5_Secante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metodo de la secante");
            Console.WriteLine("Función F(x) = x^5 - 4x -8");
            Console.WriteLine("xi+1 = xi - (f(x1) * (xi-1 - xi))/(f(xi-1) - f(xi))");
            Console.WriteLine("Valor inicial xi-1 = 0");
            Console.WriteLine("Valor inicial xi = 1");
            for(int i=0;i<12;i++){
                Console.Write("*-*-*-");
            }
            Console.WriteLine("");

            double xi_m1 = 0;
            double xi = 1;
            double Fxi_m1 = Math.Pow(xi_m1,5) - (4*xi_m1) -8;
            double Fxi = Math.Pow(xi,5) - (4*xi) -8;
            double xi_p1 = xi - ((Fxi*(xi_m1-xi))/(Fxi_m1 - Fxi));
            double errorAdmitido = 0.001;
            double err = 0;

            do{
                xi_m1 = xi;
                xi = xi_p1;
                Fxi_m1 = Math.Pow(xi_m1,5) - (4*xi_m1) -8;
                Fxi = Math.Pow(xi,5) - (4*xi) -8;
                xi_p1 = xi - ((Fxi*(xi_m1-xi))/(Fxi_m1 - Fxi));
                err = Math.Abs((xi_p1 - xi)/xi_p1) * 100;

                Console.WriteLine("Error: "+err);

            }while(err>errorAdmitido);

                Console.WriteLine("El valor de la raíz es: "+xi_p1);
                
        }
    }
}
