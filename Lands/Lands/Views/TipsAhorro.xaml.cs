﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lands.ViewModels;

namespace Lands.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipsAhorro : ContentPage
    {
        public TipsAhorro()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}