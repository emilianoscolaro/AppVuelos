using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppVuelos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            AereosButtom.TextColor = Color.Black;
            OrdenadoePage nuevapagina = new OrdenadoePage();
            await Navigation.PushAsync(nuevapagina);
            AereosButtom.TextColor = Color.White;
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            PaqueteButton.TextColor = Color.Black;
            PaquetePrevia nuevapagina = new PaquetePrevia();
            await Navigation.PushAsync(nuevapagina);
            PaqueteButton.TextColor = Color.White;
        }
    }
    
}
