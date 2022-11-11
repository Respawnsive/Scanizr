using Shiny;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Prism.Ioc;
using Prism.Navigation;
using Xamarin.Forms;
using Scanizr.Sample.Forms.ViewModels;
using Scanizr.Sample.Forms.Views;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;

namespace Scanizr.Sample.Forms
{
    public class Startup : FrameworkStartup
    {
        /// <inheritdoc />
        protected override void Configure(ILoggingBuilder builder, IServiceCollection services)
        {
            services.AddSingleton<IAppInfo, AppInfoImplementation>();

            services.UseXfMaterialDialogs();
        }

        /// <inheritdoc />
        public override void ConfigureApp(Application app, IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }

        /// <inheritdoc />
        public override Task RunApp(INavigationService navigator) => navigator.NavigateAsync("NavigationPage/MainPage");
    }
}
