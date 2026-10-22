namespace test_ObtenerMayor;

class Program
{
    static void Main(string[] args)
    {
        int max = ObtenerMayor(3,5);
        Console.WriteLine(max);    
        max = ObtenerMayor(2,1);
        Console.WriteLine(max);
        max = ObtenerMayor(4,8);
        Console.WriteLine(max);
        max = ObtenerMayor(-1,-4);
        Console.WriteLine(max);       
    }

    static int ObtenerMayor(int a, int b)
    {
        int mayor;
        if (a >= b)
        {
            mayor = a;
        }
        else
        {
            mayor = b;
        }
        return mayor;
    }

}
