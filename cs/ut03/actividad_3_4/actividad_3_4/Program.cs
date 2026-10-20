namespace actividad_3_4;

class Program
{
    static void Main(string[] args)
    {
        const string RATING_1 = "horrible";
        const string RATING_2 = "bad";
        const string RATING_3 = "regulereishon";
        const string RATING_4 = "interesting";
        const string RATING_5 = "marvellous";
        const string RATING_TEXT = "The course seems to me ";
        const string RATING_WELCOME = "Mark your experience in this course:";
/*
        const string RATING_1 = "horroroso";
        const string RATING_2 = "malo";
        const string RATING_3 = "regulero";
        const string RATING_4 = "interesante";
        const string RATING_5 = "maravilloso";
        const string RATING_TEXT = "El curso me parece ";
        const string RATING_WELCOME = "Califica tu experiencia con el curso (1-5):";
*/
        Console.WriteLine(RATING_WELCOME);
        int calificacion = Convert.ToInt32(Console.ReadLine());
        string valoracion_como_texto="";
        //PROFESOR::completa el programa para que cumpla con las especificaciones del enunciado
        switch (calificacion)
        {
            case 1: valoracion_como_texto = RATING_1; break;
            case 2: valoracion_como_texto = RATING_2; break;
            case 3: valoracion_como_texto = RATING_3; break;
            case 4: valoracion_como_texto = RATING_4; break;
            case 5: valoracion_como_texto = RATING_5; break;
        }
        Console.WriteLine(RATING_TEXT + valoracion_como_texto);
        
    }
}
