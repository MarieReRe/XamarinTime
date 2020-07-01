using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using xamarin.Models;
using xamarin.Views;
using xamarin.ViewModels;

namespace xamarin.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    { 
        public ItemsPage()
        {
            InitializeComponent();
        }


        private async void ButtonOn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Xamarin.Essentials.Flashlight.TurnOnAsync();
            }
            catch (Exception)
            {

                
            }
        }
        private async void ButtonOff_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Xamarin.Essentials.Flashlight.TurnOffAsync();
            }
            catch (Exception)
            {

                
            }
        }
    }
}