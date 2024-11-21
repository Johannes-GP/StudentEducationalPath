namespace TrayectoriaEducativaGraficas.Models
{
	public class HabilidadSocioemocionalML
	{
		public required string UnidadAnalisis {  get; set; }
		public required string NivelUnidadAnalisis { get; set; }
		public required string Descripcion { get; set; }
		public required string Recomendacion { get; set; }

		public string Encabezado => $"{UnidadAnalisis} - {NivelUnidadAnalisis}";
	}
}
