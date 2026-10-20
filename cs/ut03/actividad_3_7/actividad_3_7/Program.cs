namespace actividad_3_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce números positivos. Para terminar, introduce el cero o un número negativo:");
        int numero = Convert.ToInt32(Console.ReadLine());
        int sumatorio = 0;
        //PROFESOR::usando un bucle while, completa el programa para que calcule el sumatorio de los números introducidos y lo muestre por pantalla
        while (numero>0)
        {
            // aquí irá el código sobre qué hacer en cada iteración
            // la última instrucción es volver a pedir otro número
            numero = Convert.ToInt32(Console.ReadLine());            
        }
        Console.WriteLine(sumatorio);
    }
}
