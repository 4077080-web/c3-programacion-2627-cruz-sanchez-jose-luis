namespace actividad_3_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Califica tu experiencia con el curso (1-5):");
        int calificacion = Convert.ToInt32(Console.ReadLine());
        string valoracion_como_texto="";
        //PROFESOR::completa el programa para que cumpla con las especificaciones del enunciado
        switch (calificacion)
        {
            case 1: valoracion_como_texto = "horroroso"; break;
            case 2: valoracion_como_texto = "malo"; break;
            case 3: valoracion_como_texto = "regulero"; break;
            case 4: valoracion_como_texto = "interesante"; break;
            case 5: valoracion_como_texto = "maravilloso"; break;
        }
        Console.WriteLine($"El curso te parece {valoracion_como_texto}");
    }
}
