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
    public partial class Create_Dialog : ContentPage
    {
        string login;
        public Create_Dialog()
        {
            InitializeComponent();
        }

        private async void CreateDialog_Enter (object sender, EventArgs e)
        {
            login = loginEntry.Text;

            //запрос на создание диалога с login

            MessagingCenter.Send<Page>(this, "Dialogs_Refresh");
            await Navigation.PopAsync();
        }
    }
}