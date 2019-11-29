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
    public partial class PaquetePage : ContentPage
    {
        public PaquetePage(Model.Destino item,Model.Hotel itemH)
        {
            InitializeComponent();
            BindingContext = new PaquetePageMVVM(item, itemH);
        }
    }
}