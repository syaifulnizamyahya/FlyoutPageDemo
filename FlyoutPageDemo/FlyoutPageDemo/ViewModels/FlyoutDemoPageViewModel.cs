using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyoutPageDemo.ViewModels
{
    internal class FlyoutDemoPageViewModel
    {
        private readonly INavigationService _navigationService;

        public FlyoutDemoPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }

        public DelegateCommand<string> NavigateCommand { get; }

        private async void OnNavigateCommandExecuted(string uri)
        {
            await _navigationService.NavigateAsync(uri);
        }
    }
}
