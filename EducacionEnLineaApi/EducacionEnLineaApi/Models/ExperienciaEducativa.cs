namespace EducacionEnLineaApi.Models
{
    public class ExperienciaEducativa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int IdProgramaEducativo { get; set; }
        public virtual ProgramaEducativo ProgramaEducativo { get; set; }
    }
}
