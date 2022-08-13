using MyscoundApp.Models;
using MyscoundApp.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyscoundApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrasion : ContentPage
    {
    
       public IList<Order> orders { get; set; }
        public Registrasion()
        {
            InitializeComponent();
            GetRegistration();
        }
        public async void GetRegistration()
        {
            Order order1 = new Order();
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://montemagno.com/monkeys.json");
            var order = JsonConvert.DeserializeObject<List<Order>>(response);
            order.ForEach(x => x.Longitude1 = 10);
            orders = order;
            BindingContext = this;
           
        }
    }
}