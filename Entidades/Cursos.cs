namespace CoreEscuela.Entidades
{
    public class Curso
    {   
        public string Apellido {get;set;}
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornadas Jornada { get; set; }

        public Curso() => UniqueId = Guid.NewGuid().ToString();

        public Curso(string apellido){
            UniqueId = Guid.NewGuid().ToString();
            Apellido = apellido;
            }

    }
}