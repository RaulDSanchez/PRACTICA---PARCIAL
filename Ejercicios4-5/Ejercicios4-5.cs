using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios4_5
{
    // ==============================
    // Clase base Animal
    // ==============================
    // Esta clase será la clase padre.
    // Contiene un método virtual que podrá ser sobrescrito.
    class Animal
    {
        // Método virtual para permitir polimorfismo
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }

    // ==============================
    // Clase hija Perro
    // ==============================
    // Hereda de Animal
    class Perro : Animal
    {
        // Sobrescribimos el método
        public override void HacerSonido()
        {
            Console.WriteLine("Guau, guau");
        }
    }

    // ==============================
    // Clase hija Gato
    // ==============================
    // Hereda de Animal
    class Gato : Animal
    {
        // Sobrescribimos el método
        public override void HacerSonido()
        {
            Console.WriteLine("Miau");
        }
    }

    // ==============================
    // Clase principal
    // ==============================
    class Program
    {
        static void Main(string[] args)
        {
            // ==============================
            // Parte 1: Crear objetos individuales
            // ==============================
            Perro miPerro = new Perro();
            Gato miGato = new Gato();

            Console.WriteLine("=== Sonidos individuales ===");
            miPerro.HacerSonido();
            miGato.HacerSonido();

            Console.WriteLine(); // Salto de línea

            // ==============================
            // Parte 2: Polimorfismo
            // ==============================

            // Creamos una lista del tipo Animal
            List<Animal> animales = new List<Animal>();

            // Agregamos objetos de diferentes tipos
            animales.Add(miPerro);
            animales.Add(miGato);

            Console.WriteLine("=== Sonidos usando polimorfismo ===");

            // Recorremos la lista
            foreach (Animal animal in animales)
            {
                // Aquí ocurre el polimorfismo:
                // Aunque la lista es tipo Animal,
                // se ejecuta el método correspondiente
                // según el tipo real del objeto.
                animal.HacerSonido();
            }

            Console.ReadLine();
        }
    }
}
