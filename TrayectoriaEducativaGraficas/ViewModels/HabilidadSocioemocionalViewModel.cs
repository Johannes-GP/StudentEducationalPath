using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using TrayectoriaEducativaGraficas.Models;

namespace TrayectoriaEducativaGraficas.ViewModels
{
	public partial class HabilidadSocioemocionalViewModel : ObservableObject
	{
		public ObservableCollection<HabilidadSocioemocionalML> HabilidadesSocioemocionales { get; } = [];

		public HabilidadSocioemocionalViewModel()
		{
			HabilidadesSocioemocionales =
			[
				new() { UnidadAnalisis = "Autoconocimiento", NivelUnidadAnalisis = "Avanzado", Descripcion = "Descripción de la unidad de análisis...", Recomendacion = "Recomendación de la unidad de análisis..." },
				new() { UnidadAnalisis = "Autonomía", NivelUnidadAnalisis = "Intermedio", Descripcion = "Descripción de la unidad de análisis...", Recomendacion = "Recomendación de la unidad de análisis..." },
				new() { UnidadAnalisis = "Autorregulación", NivelUnidadAnalisis = "Inicial", Descripcion = "Descripción de la unidad de análisis...", Recomendacion = "Recomendación de la unidad de análisis..." },
				new() { UnidadAnalisis = "Colaboración", NivelUnidadAnalisis = "Básico", Descripcion = "Descripción de la unidad de análisis...", Recomendacion = "Recomendación de la unidad de análisis..." },
				new() { UnidadAnalisis = "Empatía", NivelUnidadAnalisis = "Básico", Descripcion = "Descripción de la unidad de análisis...", Recomendacion = "Recomendación de la unidad de análisis..." },
			];
		}
	}
}
