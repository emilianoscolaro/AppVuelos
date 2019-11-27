using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppVuelos.ViewModels;

namespace AppVuelos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaquetePrevia : ContentPage
    {
        public PaquetePrevia()
        {
            InitializeComponent();
            BindingContext = new PaquetePreviaMVVM();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
            ((NavigationPage)Application.Current.MainPage).Title = "Solo Aereos";
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
        }
    }
}