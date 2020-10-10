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
    public partial class DBLogin : ContentPage
    {
        string login, password;
        public DBLogin()
        {
            InitializeComponent();
        }

        private async void DB_Login (object sender, EventArgs e)
        {
            login = loginEntry.Text;
            password = passwordEntry.Text;

            //создание объекта и вызов метода класса коннекта к бд и мб сети

            await Navigation.PushAsync(new Login());
        }
    }
}