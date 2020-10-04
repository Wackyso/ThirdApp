using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThirdApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        string login, password;
        public Login()
        {
            InitializeComponent();
        }

        private async void User_Enter (object sender, EventArgs e)
        {
            login = loginEntry.Text;
            password = passwordEntry.Text;
            
            //запрос на создание объекта и вызов метода класса работы с бд

            await Navigation.PushAsync(new MainPage());
        }

        private async void User_Create (object sender, EventArgs e)
        {
            login = loginEntry.Text;
            password = passwordEntry.Text;

            //запрос на создание объекта и вызов метода класса работы с бд

            await Navigation.PushAsync(new MainPage());
        }
    }
}