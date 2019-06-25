using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProbadorSubprocesos
{
    class ImpresoraMensajes
    {
        #region Campos Privados
        private int tiempoInactividad;
        private static Random aleatorio = new Random();
        #endregion



        #region Constructor
        public ImpresoraMensajes()
        {
            // Elije tiempo de inactividad aleatorio entre 0 y 5 segundos (5001 milisegundos)
            tiempoInactividad = aleatorio.Next(5001);
        }
        #endregion



        #region Métodos Públicos
        public void Imprimir()
        {
            // Obtiene la referencia al subproceso que se ejecuta en este momento.
            Thread actual = Thread.CurrentThread;
            Console.WriteLine($"{actual.Name} va a estar inactivo durante {tiempoInactividad} milisegundos");

            // Inactivo durante tiempoInactividad milisegundos
            Thread.Sleep(tiempoInactividad);

            // Imprime el nombre del subproceso
            Console.WriteLine($"{actual.Name} dejó de estar inactivo");
        }
        #endregion
    }
}
