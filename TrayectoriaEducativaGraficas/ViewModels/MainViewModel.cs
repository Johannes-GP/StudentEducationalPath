using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TrayectoriaEducativaGraficas.Models;
using TrayectoriaEducativaGraficas.Services;
using TrayectoriaEducativaGraficas.Views;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TrayectoriaEducativaGraficas.ViewModels
{
	public partial class MainViewModel : ObservableObject
	{
		private readonly IObtenerEvaluacionRIMAService _rimaService;

		[ObservableProperty]
		private bool _isPopupOpen;

		[ObservableProperty]
		private bool _isBusy;

		public ObservableCollection<CampoFormativo> CamposFormativos { get; } = [];
		public ObservableCollection<UnidadAnalisis> DatosGrid { get; } = [];

		public MainViewModel(IObtenerEvaluacionRIMAService rimaService)
		{
			_rimaService = rimaService;
			DatosGrid =
			[ 
				new() { Nombre = "Asignatura 1", NivelDesempeno = "Bueno" },
				new() { Nombre = "Asignatura 2", NivelDesempeno = "Regular" },
				new() { Nombre = "Asignatura 3", NivelDesempeno = "Malo" }
			];
		}

		[RelayCommand]
		private async Task LoadDataAsync()
		{
			IsBusy = true;

			var evaluacion = await _rimaService.ObtenerEvaluacionRIMA();

			CamposFormativos.Clear();

			foreach (var campo in evaluacion.CamposFormativos)
			{
				CamposFormativos.Add(campo);
			}

			IsBusy = false;
		}

		[RelayCommand]
		private async Task NavigateToHabilidadSocioemocional()
		{
			await Shell.Current.GoToAsync($"{nameof(HabilidadSocioemocionalPage)}");
		}

		[RelayCommand]
		private async Task NavigateToAfinidadVocacional()
		{
			await Shell.Current.GoToAsync($"{nameof(AfinidadVocacional)}");
		}

		[RelayCommand]
		private async Task NavigateToDetail(CampoFormativo campoFormativo)
		{
			if (campoFormativo == null)
			{
				return;
			}

			var parametroNavegacion = new Dictionary<string, object>
			{
				{ "CampoFormativo", campoFormativo }
			};

			await Shell.Current.GoToAsync($"{nameof(CampoFormativoDetailPage)}", parametroNavegacion);
		}

		[RelayCommand]
		public void MostrarModal()
		{
			IsPopupOpen = true;
		}

		[RelayCommand]
		public void CerrarModal()
		{
			IsPopupOpen = false;
		}
	}
}
