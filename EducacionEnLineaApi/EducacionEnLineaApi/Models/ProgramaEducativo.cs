namespace EducacionEnLineaApi.Models
{
    public class ProgramaEducativo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Modalidad { get; set; }
        public string Metadato { get; set; }

        public int IdAreaAcademica { get; set; }
        public int IdGrado { get; set; }

        public virtual AreaAcademica AreaAcademica { get; set; }
        public virtual Grado Grado { get; set; }
    }
}
