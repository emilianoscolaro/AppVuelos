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
        public PaquetePage(Model.Destino item, Model.Hotel Hitem, Model.PickerList Pick, string Precio, bool CheckTransfer, bool CkAsistencia, bool CkBolso, bool CkTrasladoCasa, bool CkValija,
           DateTime Salida,DateTime Llegada,Model.PickerList Cia,Model.PickerList Escala,Model.PickerList Shs,Model.PickerList ShsV,Model.PickerList Lhs 
            ,Model.PickerList LhsV,Model.PickerList Smin,Model.PickerList SminV,Model.PickerList Lmin,Model.PickerList LminV)
        {
            InitializeComponent();
            BindingContext = new PaquetePageMVVM(item,Hitem,Pick,Precio,CheckTransfer,CkAsistencia,CkBolso,CkTrasladoCasa,CkValija,Salida
                ,Llegada,Cia,Escala,Shs,ShsV,Lhs,LhsV,Smin,SminV,Lmin,LminV);
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}