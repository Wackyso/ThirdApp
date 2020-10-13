using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThirdApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DialogPage : ContentPage
    {
        DateTime localDate = DateTime.Now;
        public string name { get; set; }
        public int ID { get; set; }
        public List<Message> Messages { get; set; }
        Dialog dialog;
        request_objs ReqO;
        public DialogPage(request_objs ReqO, List<Message> Messages)
        {
            this.ReqO = ReqO;
            this.Messages= Messages;
            InitializeComponent();

            /*Dialog = new List<Message>
            {
                new Message { position=1, text = "1lolololo"},
                new Message {position=1, text = "2lolololo"},
                new Message {position=2, text = "3lolololo"},
                new Message {position=2, text = "4lolololo"},
                new Message {position=1, text = "lolololo"},
                new Message {position=2, text = "lolololo"}
            };*/
            this.BindingContext = this;
        }//{Binding text}" FontSize="38" HorizontalOptions=" {Binding position}

        private void DialogPage_Send(object sender, EventArgs e)
        {

            ReqO.message = message.Text;

            NetService net = new NetService();
            
            net.AddMessage(ReqO,localDate);
            ReqO.message = "";
        }

        private async void DialogPage_Refresh(object sender, EventArgs e)
        {
            NetService net = new NetService();
            List<Message> Messages = new List<Message> { };

            IEnumerable<Message> messages = await net.GetMessages(ReqO);
            ре
            foreach (Message m in messages)
                Messages.Add(m);
            await Navigation.PushAsync(new DialogPage(ReqO, Messages));
        }

        private void DialogPage_Options(object sender, EventArgs e)
        {

        }
    }
}