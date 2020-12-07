using Android.App;
using Android.Net;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyFirstApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFirstApp.Droid.Data;

[assembly: Xamarin.Forms.Dependency(typeof(NetworkConnection))]

namespace MyFirstApp.Droid.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnected { get; set; }

        public void CheckNetworkConnection()
        {
            var ConnectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Context.ConnectivityService);
            var ActiveNertworkInfo = ConnectivityManager.ActiveNetworkInfo;
            if(ActiveNertworkInfo != null && ActiveNertworkInfo.IsConnectedOrConnecting)
            {
                IsConnected = true;
            } else
            {
                IsConnected = false;
            }
        }
    }
}