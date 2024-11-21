namespace TrayectoriaEducativaGraficas.Models
{
    public class CampoFormativo
    {
        public string Nombre { get; set; }
        public string Resultado { get; set; }
        public List<UnidadAnalisis> UnidadesAnalisis { get; set; }
        public List<Dimension> Dimensiones { get; set; }
        public List<AreaInteres> AreasInteres { get; set; }
        public List<Pregunta> Preguntas { get; set; }
    }
}
