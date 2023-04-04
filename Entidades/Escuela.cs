namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre{
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AnioDeCreacion {get; set;}
        public string Pais {get; set;}
        public string Ciudad {get; set;}

        // public Escuela(string nombre, int anio)
        // {
        //     this.nombre = nombre;
        //     AnioDeCreacion = anio;
        // }

        public Escuela(string nombre, int anio) => (Nombre,AnioDeCreacion) = (nombre,anio);

    }
}