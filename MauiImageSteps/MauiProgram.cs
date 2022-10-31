using MauiImageSteps.Service;
using MauiImageSteps.ViewModels;

namespace MauiImageSteps;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<PikachuService>();
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
	}
}
