using MarsRover.Enums;
using MarsRover.Models;

namespace MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtén los datos de la cuadrícula
            Console.Write("Introduzca el tamaño X de la cuadrícula: ");
            int tamanyoX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca el tamaño Y de la cuadrícula: ");
            int tamanyoY = Convert.ToInt32(Console.ReadLine());

            Cuadricula cuadricula = new Cuadricula(tamanyoX, tamanyoY);

            // Obtén las coordenadas iniciales del rover
            Console.Write("Introduzca la coordenada X inicial del rover: ");
            int posX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca la coordenada Y inicial del rover: ");
            int posY = Convert.ToInt32(Console.ReadLine());

            Coordenada inicio = new Coordenada(posX, posY);

            // Obtén la orientación inicial del rover
            Console.Write("Introduzca la orientación inicial del rover (NORTE, ESTE, SUR, OESTE): ");
            string orientacionStr = Console.ReadLine();
            Orientaciones orientacionInicial = (Orientaciones)Enum.Parse(typeof(Orientaciones), orientacionStr.ToUpper());

            // Crea el rover
            Rover rover = new Rover(cuadricula, inicio, new Orientacion(orientacionInicial));

            // Obtén y ejecuta las instrucciones
            Console.Write("Introduzca las instrucciones para el rover (ej. MLMR): ");
            string instruccionesStr = Console.ReadLine();
            Instrucciones instrucciones = new Instrucciones(instruccionesStr);

            RoverController controller = new RoverController(rover, instrucciones);
            controller.EjecutarInstrucciones();

            // Muestra la posición y orientación finales del rover
            Console.WriteLine($"La posición final del rover es ({rover.Coordenadas.X},{rover.Coordenadas.Y})");
            Console.WriteLine($"La orientación final del rover es {rover.Orientacion.Valor}");
        }
    }
}