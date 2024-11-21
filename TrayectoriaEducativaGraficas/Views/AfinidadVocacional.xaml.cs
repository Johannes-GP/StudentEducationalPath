using TrayectoriaEducativaGraficas.ViewModels;

namespace TrayectoriaEducativaGraficas.Views;

public partial class AfinidadVocacional : ContentPage
{
	public AfinidadVocacional(AfinidadVocacionalViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}