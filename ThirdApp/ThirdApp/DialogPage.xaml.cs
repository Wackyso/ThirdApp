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
    public partial class DialogPage : ContentPage
    {
        public string name { get; set; }
        public int ID { get; set; }
        public DialogPage(string name, int ID)
        {
            this.name = name;
            this.ID = ID;
            InitializeComponent();
        }

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