using System;

// Clase simple que representa una persona
class Persona
{
    // Propiedades públicas
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // Constructor para inicializar valores
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    // Método que imprime una presentación
    public void Presentarse()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}
