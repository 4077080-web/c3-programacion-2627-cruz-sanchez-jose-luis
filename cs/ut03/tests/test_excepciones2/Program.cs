namespace test_excepciones2;

class Program
{
    static void Main(string[] args)
    {
        try
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
        catch (FormatException ex)
        {
            Console.WriteLine("Alguno de los números no tiene un formato correcto");
        }
        //Aquí el tratamiento por si alguien pone cero de divisor
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Se ha intentado dividir por cero: {ex:Message}");            
        }
        //Esto se ejecuta siempre
        finally
        {
            Console.WriteLine("Felizmente, pase lo que pase, esto se va a ejecutar");
        }
        //Pongo esta línea para ver si el programa se ha interrumpido o no
        Console.WriteLine("El programa termina aquí");
    }
}
