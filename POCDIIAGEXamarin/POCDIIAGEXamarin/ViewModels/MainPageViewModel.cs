using Prism.Commands;
using Prism.Navigation;
using System;

namespace POCDIIAGEXamarin.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand SecondPageCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.Title = "Main Page";
            SecondPageCommand = new DelegateCommand(NavigationToSecondPage);
        }

        private void NavigationToSecondPage()
        {
            this.NavigationService.NavigateAsync("SecondPage");
        }
    }
}
