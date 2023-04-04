using CoreEscuela.Entidades;

namespace Etapa1
{
    class program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela( "Quizer Academy",2023);
            escuela.Pais= "El Salvador";
            escuela.Ciudad= "Sonsonate";
            Console.WriteLine(escuela.Nombre);
        }
    }
}