using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ThirdApp
{
    
        

    public partial class MainPage : ContentPage
    {
        public List<Dialog> Dialogs { get; set; }
        NetService net;
        public MainPage(request_objs ReqO, List<Dialog> dialogs)
        {
            //Dialogs = new List<Dialog>();
            //net = new NetService();

            //IEnumerable<Dialog> dialogs = await net.GetDialogs();
            Dialogs = dialogs;
           /* Dialogs = new List<Dialog>
            {
                new Dialog {Name="pas"},
                new Dialog {Name="ole"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"},
                new Dialog {Name="pas"}
            };*/
            this.BindingContext = this;

            InitializeComponent();

            Subscribe();
        }

        private void Subscribe()
        {
            MessagingCenter.Subscribe<Page>(
                this, // кто подписывается на сообщения
                "Dialogs_Refresh",   // название сообщения
                (sender) => { Refresh(); });    // вызываемое действие

        }

        private async void Overview_CreateDialog (object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Create_Dialog());
        }

        private void Overview_Refresh(object sender, EventArgs e)
        {
            //Refresh(); 
        }

        private async void Overview_JoinDialog(object sender, ItemTappedEventArgs e)
        {
            Dialog talk = e.Item as Dialog;
            
            await Navigation.PushAsync(new DialogPage(talk.Name, talk.ID));
        }

        private void Dialog_Send(object sender, EventArgs e)
        {

        }

        private void Dialog_Refresh(object sender, EventArgs e)
        {

        }

        private void Refresh()
        {
            //запрос диалогов из бд и метод обновления
        }
    }
}
