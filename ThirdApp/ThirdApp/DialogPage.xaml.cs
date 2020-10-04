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
        public class Phrase
        {
            public int position { get; set; }
            
            public string text { get; set; }
        }
        public string name { get; set; }
        public int ID { get; set; }
        public List<Phrase> Dialog { get; set; }
        public DialogPage(string name, int ID)
        {
            this.name = name;
            this.ID = ID;
            InitializeComponent();

            Dialog = new List<Phrase>
            {
                new Phrase {position=1, text = "1lolololo"},
                new Phrase {position=1, text = "2lolololo"},
                new Phrase {position=2, text = "3lolololo"},
                new Phrase {position=2, text = "4lolololo"},
                new Phrase {position=1, text = "lolololo"},
                new Phrase {position=2, text = "lolololo"}
            };
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