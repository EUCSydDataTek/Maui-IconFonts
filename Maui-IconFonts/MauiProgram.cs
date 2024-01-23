using Microsoft.Extensions.Logging;

namespace Maui_IconFonts;

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
				fonts.AddFont("RobotoSerif-Black.ttf", "Roboto");
				fonts.AddFont("fa-solid-900.ttf", "FA-solid");
                fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialRegular");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
