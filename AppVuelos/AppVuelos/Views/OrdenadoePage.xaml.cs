using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVuelos.ViewModels;
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
            BindingContext = new PaquetePreviaMVVM(Navigation);
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
            ((NavigationPage)Application.Current.MainPage).Title = "Paquete";
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;
        }

    }
}