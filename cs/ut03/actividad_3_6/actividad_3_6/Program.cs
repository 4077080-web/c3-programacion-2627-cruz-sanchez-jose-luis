namespace actividad_3_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Vamos a calcular! Escribe un número entero positivo entre 10 y 20:");
        int limite_maximo = Convert.ToInt32(Console.ReadLine());
        long factorial=1;
        long sumatorio=0;
        //PROFESOR::usando un bucle for, completa el programa para que calcule el sumatorio y el factorial del número introducido y los muestre por pantalla
        for (int n=1;n<=limite_maximo;n++)
        {
            sumatorio = sumatorio + n; // forma abreviada equivalente: sumatorio += n;
            factorial = factorial * n; // forma abreviada equivalente: factorial *= n;
        }
        Console.WriteLine($"El sumatorio es {sumatorio}");
        Console.WriteLine($"El factorial es {factorial}");
    }
}
