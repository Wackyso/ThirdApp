using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;

namespace ThirdApp
{
    class Network
    {
        public bool connection;
         public Network ()
        {
            if (CrossConnectivity.Current != null &&
                CrossConnectivity.Current.ConnectionTypes != null &&
                CrossConnectivity.Current.IsConnected == true)
            {
                connection = true;
            }
        }

        public bool checkconnection ()
        {
            if (CrossConnectivity.Current != null &&
                            CrossConnectivity.Current.ConnectionTypes != null &&
                            CrossConnectivity.Current.IsConnected == true)
            {
                connection = true;
            }
            else
                connection = false;

            return connection;
        }
    }
}
