using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace POCDIIAGEXamarin.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        private bool _isAdmin;
        private string _textLabel;

        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { SetProperty(ref _isAdmin, value); }
        }

        public string TextLabel
        {
            get { return _textLabel; }
            set { SetProperty(ref _textLabel, value); }
        }

        public SecondPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.Title = "Second Page";
        }
    }
}
