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
    public partial class Aereos : ContentPage
    {
        public Aereos()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Transparent;
        }
    }
}