using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVuelos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdenadoePage : ContentPage
    {
        public OrdenadoePage()
        {
            InitializeComponent();
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Aereos nuevapagina = new Aereos();
            await Navigation.PushAsync(nuevapagina);
        }
    }
}