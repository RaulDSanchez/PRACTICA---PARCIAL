using System;

namespace ProyectoPOO
{
    // =============================
    // EJERCICIO 6: Encapsulamiento
    // =============================
    class CuentaBancaria
    {
        // Atributo privado para encapsular el saldo
        private decimal saldo;

        // Constructor para inicializar la cuenta bancaria
        public CuentaBancaria()
        {
            saldo = 0;
        }

        // Método para depositar dinero
        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                saldo += monto;
                Console.WriteLine($"Depositado: {monto:C}");
            }
            else
            {
                Console.WriteLine("El monto debe ser positivo.");
            }
        }

        // Método para obtener el saldo actual
        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }

    // =====================================
    // EJERCICIO 7: Interfaces y abstracción
    // =====================================
    interface IVehiculo
    {
        void Encender();
        void Apagar();
    }

    // Implementación para Carro
    class Carro : IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("Carro encendido: ¡Vroom vrooom!");
        }

        public void Apagar()
        {
            Console.WriteLine("Carro apagado.");
        }
    }

    // Implementación para Motocicleta
    class Motocicleta : IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("Motocicleta encendida: ¡Brrrrrrrr!");
        }

        public void Apagar()
        {
            Console.WriteLine("Motocicleta apagada.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EJERCICIO 6: ENCAPSULAMIENTO ===\n");
            
            // Crear cuenta bancaria y realizar operaciones
            CuentaBancaria cuenta = new CuentaBancaria();
            cuenta.Depositar(500.50m);
            cuenta.Depositar(1000m);
            Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo():C}");

            Console.WriteLine("\n=== EJERCICIO 7: INTERFACES ===\n");
            
            // Crear vehículos e interactuar con ellos
            IVehiculo carro = new Carro();
            IVehiculo moto = new Motocicleta();

            Console.WriteLine("--- Probando carro ---");
            carro.Encender();
            carro.Apagar();

            Console.WriteLine();

            Console.WriteLine("--- Probando motocicleta ---");
            moto.Encender();
            moto.Apagar();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}