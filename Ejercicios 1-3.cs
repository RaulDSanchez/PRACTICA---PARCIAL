using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    // 1. Sintaxis básica y variables
    {
        // Mensaje de bienvenida
        Console.WriteLine("¡Saludos! Damos comienzo al proyecto más heavy y bacano, funcionando con más eficiencia que un estudiante que descubre que la entrega es hoy y no mañana.");

        // Declaración de variables de distintos tipos
        Console.WriteLine("\nTipos de variables:");
        int numero = 08;
        string mensaje = "Klk Profe";
        double pi = 3.1415;
        bool activo = true;

        // Impresión de las variables
        Console.WriteLine($"int: {numero}");
        Console.WriteLine($"string: {mensaje}");
        Console.WriteLine($"double: {pi}");
        Console.WriteLine($"bool: {activo}");

        //2. Estructuras de control

        // Pide al usuario un número
        Console.Write("\nIngresa un número: ");
        int n = int.Parse(Console.ReadLine());

        // Condicional para determinar si el número es par o impar
        if (n % 2 == 0)
            Console.WriteLine("El número es PAR.");
        else
            Console.WriteLine("El número es IMPAR.");

        // Bucle for imprimendo del 1 al 10
        Console.WriteLine("\nNúmeros del 1 al 10:");
        for (int i = 1; i <= 10; i++)
            Console.WriteLine(i);

        //3. Clases y objetos

        // Se crean 3 objetos Persona (ejemplo de instanciación)
        Persona p1 = new Persona("Esmeralda", 20);
        Persona p2 = new Persona("Jordi", 21);
        Persona p3 = new Persona("Raul", 20);

        // Presentación de los integrantes
        Console.WriteLine("\nPresentación de integrantes:");
        p1.Presentarse();
        p2.Presentarse();
        p3.Presentarse();

    }


}