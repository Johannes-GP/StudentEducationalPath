using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Telerik.Maui.Controls.Compatibility;
using TrayectoriaEducativaGraficas.Services;
using TrayectoriaEducativaGraficas.ViewModels;
using TrayectoriaEducativaGraficas.Views;

namespace TrayectoriaEducativaGraficas
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.UseMauiCommunityToolkit()
				.UseTelerik()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
					fonts.AddFont("telerikcontrolsicons.ttf", "TelerikControlsIcons");
					fonts.AddFont("telerikfontexamples.ttf", "TelerikFontExamples");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif
			
			builder.Services.AddTransient<MainPage>();
			builder.Services.AddTransient<MainViewModel>();

			builder.Services.AddTransient<CampoFormativoDetailPage>();
			builder.Services.AddTransient<CampoFormativoDetailViewModel>();

			builder.Services.AddTransient<HabilidadSocioemocionalPage>();
			builder.Services.AddTransient<HabilidadSocioemocionalViewModel>();

			builder.Services.AddTransient<AfinidadVocacional>();
			builder.Services.AddTransient<AfinidadVocacionalViewModel>();

			builder.Services.AddSingleton<IObtenerEvaluacionRIMAService, ObtenerEvaluacionRIMAService>();

			return builder.Build();
		}
	}
}
