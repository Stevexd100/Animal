
class Perro : Animal
{
    public string Raza {get; set;}

    public Perro(string nombre, int edad, string raza)
    :base(nombre, edad)
    {
        Raza = raza ;
    }

    public new void HacerSonido()
    {
        Console.WriteLine(Nombre + " dice: ¡Guau!");
    }

    public void Buscar()
    {
        Console.WriteLine(Nombre + " esta buscando algo...");
    }
}

public class Program
{
    static void Main()
    {
        Perro perrito =new Perro(" Troquito",5, "Pug");
        perrito.MostrarInfo();
        perrito.HacerSonido();
        perrito.Buscar();

        Console.WriteLine(" Raza: "+ perrito.Raza);
    }

}