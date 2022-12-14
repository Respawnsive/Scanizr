using CommunityToolkit.Maui;
using Prism.DryIoc;

namespace Scanizr.Sample.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp
                .CreateBuilder()
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseShinyFramework(
                    new DryIocContainerExtension(),
                    prism => prism.OnAppStart("NavigationPage/MainPage")
                )
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            RegisterServices(builder);
            RegisterViews(builder.Services);

            return builder.Build();
        }


        static void RegisterServices(MauiAppBuilder builder)
        {
            var s = builder.Services;

            s.AddSingleton(MediaPicker.Default);
            s.AddDataAnnotationValidation();
            s.AddGlobalCommandExceptionHandler(new(
#if DEBUG
            ErrorAlertType.FullError
#else
                ErrorAlertType.NoLocalize
#endif
            ));
        }


        static void RegisterViews(IServiceCollection s)
        {
            s.RegisterForNavigation<MainPage, MainViewModel>();
        }
    }
}