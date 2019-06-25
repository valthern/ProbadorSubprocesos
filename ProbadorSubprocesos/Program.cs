using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProbadorSubprocesos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea y asigna un nombre a cada subproceso. usa el método Imprimir de ImpresoraMensajes comoa rgumento para el delegado ThreadStart.
            ImpresoraMensajes impresora1 = new ImpresoraMensajes();
            Thread subproceso1 = new Thread(new ThreadStart(impresora1.Imprimir));
            subproceso1.Name = "subproceso1";

            ImpresoraMensajes impresora2 = new ImpresoraMensajes();
            Thread subproceso2 = new Thread(new ThreadStart(impresora2.Imprimir));
            subproceso2.Name = "subproceso2";

            ImpresoraMensajes impresora3 = new ImpresoraMensajes();
            Thread subproceso3 = new Thread(new ThreadStart(impresora3.Imprimir));
            subproceso3.Name = "subproceso3";

            Console.WriteLine("Iniciando Subprocesos");

            // Llama al método Start de cada subproceso para colocar a cada uno de ellos en el estado Running
            subproceso1.Start();
            subproceso2.Start();
            subproceso3.Start();

            Console.WriteLine("Subprocesos iniciados\n");
            Console.ReadLine();
        }
    }
}
