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
        request_objs ReqO;
        public MainPage(request_objs ReqO, List<Dialog> dialogs)
        {
            //Dialogs = new List<Dialog>();
            //net = new NetService();
            this.ReqO = ReqO;
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
            await Navigation.PushAsync(new Create_Dialog(ReqO));
        }

        private void Overview_Refresh(object sender, EventArgs e)
        {
            Refresh();
        }

        private async void Overview_JoinDialog(object sender, ItemTappedEventArgs e)
        {
            NetService net = new NetService();
            Dialog talk = e.Item as Dialog;
            List<Message> Messages = new List<Message> { };

            ReqO.dialog_id = talk.ID;

            IEnumerable<Message> messages = await net.GetMessages(ReqO);

            foreach (Message m in messages)
                Messages.Add(m);

            await Navigation.PushAsync(new DialogPage(ReqO, Messages));
        }


        private async void Refresh()
        {
            NetService net = new NetService();


            List<Dialog> Dialogs = new List<Dialog> { };
            IEnumerable<Dialog> dialogs = await net.GetDialogs(ReqO);

            
            foreach (Dialog d in dialogs)
                Dialogs.Add(d);
        }
    }
}
