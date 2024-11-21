using TrayectoriaEducativaGraficas.ViewModels;

namespace TrayectoriaEducativaGraficas.Views;

public partial class CampoFormativoDetailPage : ContentPage
{
	public CampoFormativoDetailPage(CampoFormativoDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}