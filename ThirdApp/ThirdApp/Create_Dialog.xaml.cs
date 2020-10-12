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
        string interlocutor;
        request_objs ReqO;
        public Create_Dialog(request_objs ReqO)
        {
            this.ReqO = ReqO;
            InitializeComponent();
        }

        private async void CreateDialog_Enter (object sender, EventArgs e)
        {
            interlocutor = loginEntry.Text;
            NetService net = new NetService();
            net.AddDialog(ReqO, interlocutor);
            //запрос на создание диалога с login

            MessagingCenter.Send<Page>(this, "Dialogs_Refresh");
            await Navigation.PopAsync();
        }
    }
}