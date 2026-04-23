using System;


public class Animal
{
    public string Nombre{get; set;}

    public int Edad{get; set;}

    public Animal(string nombre, int edad)
    {
        Nombre = nombre ;
        Edad = edad ;
    }

    public void HacerSonido()
    {
        Console.WriteLine(Nombre + "Hace un sonido.");
    }
    
    public void MostrarInfo()
    {
        Console.WriteLine("Nombre:" + Nombre + ", Edad:"+ Edad);
    }
}