using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ThirdApp
{
    class StartPage : ContentPage 
    {
        public StartPage()
        {
            Label header = new Label() { Text = "hi fron ukraine " };
            this.Content = header;
        }
    }
}
