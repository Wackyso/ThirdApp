﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThirdApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        
        
        public Login()
        {
            InitializeComponent();
            Network net = new Network();
        }

        private async void User_Enter (object sender, EventArgs e)
        {
            NetService net = new NetService();

            request_objs ReqO = new request_objs(loginEntry.Text, passwordEntry.Text);

            

            List<Dialog> Dialogs = new List<Dialog> { };
            IEnumerable<Dialog> dialogs = await net.GetDialogs(ReqO);

            foreach (Dialog d in dialogs)
                Dialogs.Add(d);

            await Navigation.PushAsync(new MainPage(ReqO, Dialogs));
        }

        private async void User_Create (object sender, EventArgs e)
        {
            NetService net = new NetService();
            request_objs ReqO = new request_objs(loginEntry.Text, passwordEntry.Text);


           

            List<Dialog> Dialogs = new List<Dialog> { };
            /*IEnumerable<Dialog> dialogs = await*/ net.CreateAcc(ReqO);

            //foreach (Dialog d in dialogs)
            //    Dialogs.Add(d);

            await Navigation.PushAsync(new MainPage(ReqO, Dialogs));
        }
    }
}