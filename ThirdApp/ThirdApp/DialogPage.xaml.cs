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
        
        public string name { get; set; }
        public int ID { get; set; }
        public List<Message> Messages { get; set; }
        Dialog dialog;
        public DialogPage(request_objs ReqO, List<Message> Messages)
        {
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

        }

        private void DialogPage_Refresh(object sender, EventArgs e)
        {

        }

        private void DialogPage_Options(object sender, EventArgs e)
        {

        }
    }
}