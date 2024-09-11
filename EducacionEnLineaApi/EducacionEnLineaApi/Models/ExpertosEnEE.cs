namespace EducacionEnLineaApi.Models
{
    public class ExpertosEnEE
    {
        public int Id { get; set; }
        public int IdExperienciaEducativa { get; set; }  // Corregir typo
        public int IdExperto { get; set; }

        public virtual ExperienciaEducativa ExperienciaEducativa { get; set; }
        public virtual ExpertoContenido ExpertoContenido { get; set; }
    }
}
