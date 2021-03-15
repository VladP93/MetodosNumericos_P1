using System;

namespace _3_PuntoFijo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La velocidad V de un paracaidista está dada por la formula:");
            Console.WriteLine("V = gx/c * (1-e^-(c*t/x))\n");
            Console.WriteLine("g = 9.8 m/s^2  ->  gravedad terrestre");
            Console.WriteLine("t = tiempo en segundos");
            Console.WriteLine("c = 14 kg/s  ->  Coeficiente de arrastre");
            Console.WriteLine("x = Masa del paracaidista en Kg\n");
            Console.WriteLine("Cuando transcurrienron 7 segundos se detectó que la velocidad es de 35m/s");
            Console.WriteLine("Determina la masa del paracaidista con Error=0.001");

            for(int i=0;i<12;i++){
                Console.Write("*-*-*-");
            }
            Console.WriteLine("\nDespejando x:");
            Console.WriteLine("x = 490/(9.81(1-e^-(98/xi)))");
            Console.WriteLine("Donde xi = 63");

            double xi = 63;
            double x = 490/(9.81*(1 - (Math.Pow(Math.E, (-98/xi)))));
            double errorAdmitido = 0.001;
            double err = 0;

            do{
                xi = x;
                x = 490/(9.81*(1 - (Math.Pow(Math.E, (-98/xi)))));
                err = Math.Abs((x-xi)/x * 100);
            }while(err>errorAdmitido);

            Console.WriteLine("El valor de la raíz es: "+xi);
        }
    }
}
