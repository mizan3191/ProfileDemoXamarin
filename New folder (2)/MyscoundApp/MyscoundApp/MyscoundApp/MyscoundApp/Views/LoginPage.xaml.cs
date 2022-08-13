using MyscoundApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyscoundApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //this.BindingContext = new LoginViewModel();
            
        }
        private async void Loginbtn_Clicked(object sender, EventArgs e)
        {
            //null or empty field validation, check weather email and password is null or empty  
            if (string.IsNullOrEmpty(usernameEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text))
                DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                if (usernameEntry.Text == "abc" && passwordEntry.Text == "123")
                {
                    DisplayAlert("Login Success", "", "Ok");
                    //Navigate to Wellcom page after successfully login  
                    //Navigation.PushAsync(new Registrasion());
                    await Shell.Current.GoToAsync("//UserProfile");
                    //Navigation.PushAsync(new UserProfile());
                }
                else
                    DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
        }
    }
}