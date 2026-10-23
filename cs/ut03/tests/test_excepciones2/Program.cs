namespace test_excepciones2;

class Program
{
    static void Main(string[] args)
    {
        //Tomamos los datos del usuario:
        Console.WriteLine("Introduzca dividendo:");
        int dividendo = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca divisor:");
        int divisor = int.Parse(Console.ReadLine());
        //Calculamos las operaciones
        int cociente = dividendo / divisor;
        int resto = dividendo % divisor;
        //Mostramos los cálculos al usuario
        Console.WriteLine($"El cociente de la división es {cociente}");
        Console.WriteLine($"El resto de la división es {resto}");
    }
}
