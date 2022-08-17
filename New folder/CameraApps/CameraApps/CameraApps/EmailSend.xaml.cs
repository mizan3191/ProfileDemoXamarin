using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CameraApps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailSend : ContentPage
    {
        public EmailSend()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            var message = new EmailMessage
            {

                Subject = emailSubject.Text,
                Body = emailBody.Text,
                To = new List<string> { 
                    emailTo.Text
                }
            };

            await Email.ComposeAsync(message);

           await Email.ComposeAsync(emailSubject.Text, "", emailTo.Text);
        }
    }
}