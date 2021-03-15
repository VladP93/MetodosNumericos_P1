using System;

namespace _4_NewtonRaphson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Método de Newton-Raphson");
            Console.WriteLine("Función f(x) = ln x - 1/x");
            Console.WriteLine("Derivada f'(x) = (x+1)/x^2");
            Console.WriteLine("Error: 0.001");
            Console.WriteLine("Valor inicial x = 2");

            double xi = 2;
            double Fxi = Math.Log(xi) - (1/xi);
            double dFxi = (xi+1)/(Math.Pow(xi,2));
            double xi_1 = xi - (Fxi/dFxi);
            double errorAdmitido = 0.001;
            double err = 0;

            do{
                xi = xi_1;
                Fxi = Math.Log(xi) - (1/xi);
                dFxi = (xi+1)/(Math.Pow(xi,2));
                xi_1 = xi - (Fxi/dFxi);
                err = Math.Abs((xi_1 - xi)/xi_1) * 100;
                Console.WriteLine("Error: "+err);
            }while(err>errorAdmitido);

            Console.WriteLine("El valor de la raíz es: "+xi);

        }
    }
}
