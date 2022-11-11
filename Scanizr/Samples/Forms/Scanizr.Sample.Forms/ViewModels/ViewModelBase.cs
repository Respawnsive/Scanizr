using Prism.Navigation;
using Shiny;

namespace Scanizr.Sample.Forms.ViewModels
{
    public class ViewModelBase : ViewModel
    {
        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        protected INavigationService NavigationService { get; }
    }
}
