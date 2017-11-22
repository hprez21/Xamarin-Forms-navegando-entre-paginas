﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntrePages.ViewModels
{
    public class PrimeraViewModel
    {
        public Command ClickedCommand { get; set; }
        public INavigation Navigation { get; set; }
        public PrimeraViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            ClickedCommand = new Command(async () => await ALaSiguiente());
        }

        public async Task ALaSiguiente()
        {
            await Navigation.PushAsync(new Segunda());
        }
    }
}