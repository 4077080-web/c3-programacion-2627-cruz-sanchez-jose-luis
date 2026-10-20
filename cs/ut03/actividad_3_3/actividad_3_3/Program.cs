namespace actividad_3_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca su nueva contraseña (mínimo 8 caracteres, conteniendo letras mayúsculas y minúsculas):"); 
        string password = Console.ReadLine();
        //PROFESOR::completa el programa para que cumpla con las especificaciones del enunciado
        // declaro una variable entera para quedarme con la longitud de la cadena introducida por el usuario
        int longitud_password = password.Length;
        // comparlo para averiguar si cumple con la longitud mínima
        if (longitud_password<8)
        {
            Console.WriteLine("Demasiado corta, debe contener al menos 8 caracteres");
        }
        
    }
}
