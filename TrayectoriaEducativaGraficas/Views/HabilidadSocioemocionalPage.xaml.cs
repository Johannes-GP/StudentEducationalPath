using TrayectoriaEducativaGraficas.ViewModels;

namespace TrayectoriaEducativaGraficas.Views;

public partial class HabilidadSocioemocionalPage : ContentPage
{
	public HabilidadSocioemocionalPage(HabilidadSocioemocionalViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}