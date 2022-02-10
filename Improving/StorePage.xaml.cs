using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Improving
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StorePage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            onLoad();
        }
        public StorePage()
        {
            InitializeComponent();
            

        }
        public async void onLoad()
        {
            CustomerListView.ItemsSource = await App.Database.GetPeopleAsync();

        }
        

        
    }
    
}