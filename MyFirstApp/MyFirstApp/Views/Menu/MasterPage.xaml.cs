﻿using MyFirstApp.Models;
using MyFirstApp.Views.DetailViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {

        public ListView ListView { get { return listview; } }
        public List<MasterMenuItem> items;

        public MasterPage()
        {
            InitializeComponent();
            SetItems();
        }

        void SetItems()
        {
            items = new List<MasterMenuItem>();
            items.Add(new MasterMenuItem("InfoScreen1","LoginIcon.jpg", Color.White, typeof(InfoScreen1)));
            items.Add(new MasterMenuItem("InfoScreen2", "LoginIcon.jpg", Color.White, typeof(InfoScreen2)));
            ListView.ItemsSource = items;
        }
    }
}