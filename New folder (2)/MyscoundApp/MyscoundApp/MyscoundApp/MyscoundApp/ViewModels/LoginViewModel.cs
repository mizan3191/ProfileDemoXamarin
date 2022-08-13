using MyscoundApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyscoundApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string usernameEntry;
        private string passwordEntry;
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }
        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(usernameEntry)
                && !String.IsNullOrWhiteSpace(passwordEntry);
        }

        private async void OnLoginClicked(object obj)
        {
            

            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
