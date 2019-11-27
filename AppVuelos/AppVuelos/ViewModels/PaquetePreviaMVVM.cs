using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using AppVuelos.Model;
using System.Runtime.CompilerServices;

namespace AppVuelos.ViewModels
{
    public class PaquetePreviaMVVM :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public PaquetePreviaMVVM()
        {
            

        }

        private Destino _selectedDestino;

        public Destino _SelectedDestino
        {
            get { return _selectedDestino; }
            set
            {
                if (_selectedDestino != value)
                {
                    _selectedDestino = value;
                }
            }
        }



        public bool VisiblePicker;




        DataStorge datastorge = new DataStorge();

        public List<Destino> DestinosList { get; set; }





    }


}
