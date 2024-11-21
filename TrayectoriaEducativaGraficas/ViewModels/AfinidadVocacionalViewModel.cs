using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using TrayectoriaEducativaGraficas.Models;

namespace TrayectoriaEducativaGraficas.ViewModels
{
	public partial class AfinidadVocacionalViewModel : ObservableObject
	{
		public ObservableCollection<AfinidadVocacionalML> Intereses { get; set; }

		public AfinidadVocacionalViewModel()
		{
			Intereses = ObtenerInteresesEstudiante();
		}

		private static ObservableCollection<AfinidadVocacionalML> ObtenerInteresesEstudiante()
		{
			var data = new ObservableCollection<AfinidadVocacionalML>
		{
			new AfinidadVocacionalML { UnidadAnalisis = "Artista", NivelUnidadAnalisis = 7 },
			new AfinidadVocacionalML { UnidadAnalisis = "Investigador", NivelUnidadAnalisis = 9 },
			new AfinidadVocacionalML { UnidadAnalisis = "Realista", NivelUnidadAnalisis = 8 },
			new AfinidadVocacionalML { UnidadAnalisis = "Social", NivelUnidadAnalisis = 8 },
			new AfinidadVocacionalML { UnidadAnalisis = "Emprendedor", NivelUnidadAnalisis = 9 },
		};
			return data;
		}
	}
}
