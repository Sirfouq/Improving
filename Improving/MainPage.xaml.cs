using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Improving.Models;
namespace Improving
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnRegister.Clicked += Navi;
            
            
        }
        public void Navi(object sender,EventArgs e)
        {
            Navigation.PushAsync(new StorePage());
        }
        public async void OnButtonClicked(object sender,EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(User.Text) && !string.IsNullOrWhiteSpace(Pass.Text))
            {

                await App.Database.SavePersonAsync(new Customer
                {
                    Username = User.Text,
                    Password = Pass.Text
                });
                User.Text = Pass.Text = string.Empty;
                
            }
        }
    }
}
