using static System.Console;

using CoreEscuela.Entidades;

namespace Etapa1
{
    class program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Quizer Academy", 2023, TiposEscuela.Primaria, ciudad: "Sonsonate", pais: "NoseAlv");

            escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre = "101", Jornada = TiposJornadas.Matutina},
                new Curso(){Nombre = "201", Jornada = TiposJornadas.Matutina},  
                new Curso(){Nombre = "301", Jornada = TiposJornadas.Matutina}
            };

            escuela.Cursos.Add(new Curso{Nombre="102", Jornada = TiposJornadas.Vespertina});
            escuela.Cursos.Add(new Curso{Nombre="202", Jornada = TiposJornadas.Vespertina});

            var OtraColeccion = new List<Curso>(){
                new Curso(){Nombre = "401", Jornada = TiposJornadas.Matutina},
                new Curso(){Nombre = "501", Jornada = TiposJornadas.Matutina},  
                new Curso(){Nombre = "502", Jornada = TiposJornadas.Vespertina}
            };
            
            Curso tmp = new Curso(){Nombre = "101-Vacacional", Jornada = TiposJornadas.Noche};
            escuela.Cursos.Add(tmp);
            escuela.Cursos.AddRange(OtraColeccion);
            ImprimirCursosEscuela(escuela);
            WriteLine("==========================================");
            escuela.Cursos.Remove(tmp);
            ImprimirCursosEscuela(escuela);


        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            if (escuela?.Cursos != null){
                WriteLine("====================");
                WriteLine("Cursos de la Escuela");
                WriteLine("====================");
            foreach (var item in escuela.Cursos)
            {
                WriteLine($"Nombre: {item.Nombre}, ID: {item.UniqueId}, Jornada: {item.Jornada}");                
            }
        }else {
            return;
        }}

        private static void ImprimirCursosWhile(Curso[] arreglosCursos)
        {
            int contador = 0;
            while (contador < arreglosCursos.Length)
            {
                Console.WriteLine($"Nombre: {arreglosCursos[contador].Nombre}, ID: {arreglosCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arreglosCursos)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($"Nombre: {arreglosCursos[contador].Nombre}, ID: {arreglosCursos[contador].UniqueId}");
                contador++;
            } while (contador < arreglosCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arreglosCursos)
        {
            for (int i = 0; i < arreglosCursos.Length; i++)
            {
                Console.WriteLine($"Nombre: {arreglosCursos[i].Nombre}, ID: {arreglosCursos[i].UniqueId}");

            }
        }

        private static void ImprimirCursosForEach(Curso[] arreglosCursos)
        {
            foreach (var item in arreglosCursos)
            {
                Console.WriteLine($"Nombre: {item.Nombre}, ID: {item.UniqueId}");                
            }
        }
    }
}