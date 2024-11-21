using TrayectoriaEducativaGraficas.Views;

namespace TrayectoriaEducativaGraficas
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute(nameof(CampoFormativoDetailPage), typeof(CampoFormativoDetailPage));
			Routing.RegisterRoute(nameof(HabilidadSocioemocionalPage), typeof(HabilidadSocioemocionalPage));
			Routing.RegisterRoute(nameof(AfinidadVocacional), typeof(AfinidadVocacional));
		}
	}
}
