using Microsoft.AspNetCore.Components.WebView.Maui;
using SQLiteDemoWithBlazorApp.Data;
using SQLiteDemoWithBlazorApp.Services;

namespace SQLiteDemoWithBlazorApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		builder.Services.AddSingleton<IStudentService, StudentService>();
		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
