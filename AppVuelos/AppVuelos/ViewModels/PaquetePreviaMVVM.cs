using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using AppVuelos.Model;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AppVuelos.ViewModels
{
    public class PaquetePreviaMVVM : INotifyPropertyChanged 
    {
        public PaquetePreviaMVVM(INavigation navigation)
        {
            DestinosList = datastorge.GetDestinos();
            this.Navigation = navigation;
            this.Agregar = new Command(async () => await GotoPPage());
            OnPropertyChanged();

        }

        public INavigation Navigation { get; set; }

        public async Task GotoPPage()
        {
            await Navigation.PushAsync(new PaquetePage(SelectDestino));
        }





        private Destino selectdestino;

        public Destino SelectDestino
        {
            get { return selectdestino; }
            set { selectdestino = value; VisHotel = false;
                if (value == null)
                {
                    VisCiudad = false;
                }
                else
                {
                    VisCiudad = true;

                }
                _MyDestino = selectdestino.Name;
                CiudadesList = datastorge.Ciudadidentify(selectdestino.Name, CiudadesList);
                OnPropertyChanged();
            }
        }

        private Ciudad selectciudad;

        public Ciudad SelectCiudad
        {
            get { return selectciudad; }
            set { selectciudad = value;
                if (value == null)
                {
                    VisHotel = false;
                }
                else
                {
                    VisHotel = true;

                }
                HotelesList = datastorge.Hoteldidentify(selectciudad.Name, HotelesList);
                OnPropertyChanged();
            }
        }


        private bool visciudad;

        public bool VisCiudad
        {
            get { return visciudad; }
            set { visciudad = value; OnPropertyChanged(); }
        }

        private bool vishotel;

        public bool VisHotel
        {
            get { return vishotel; }
            set { vishotel = value; OnPropertyChanged(); }
        }




        DataStorge datastorge = new DataStorge();

        private List<Destino> destinoslist;

        public List<Destino> DestinosList
        {
            get { return destinoslist; }
            set { destinoslist = value; OnPropertyChanged(); }
        }

        private List<Ciudad> ciudadeslist;

        public List<Ciudad> CiudadesList
        {
            get { return ciudadeslist; }
            set { ciudadeslist = value;
                OnPropertyChanged();
            }
        }

        private List<Hotel> hoteleslist;

        public List<Hotel> HotelesList
        {
            get { return hoteleslist; }
            set { hoteleslist = value; OnPropertyChanged(); }
        }


        private string _mydestino;

        public string _MyDestino
        {
            get { return _mydestino; }
            set { _mydestino = SelectDestino.Name; }
        }



        private Command agregarCommand;

        public Command Agregar
        {
            get { return agregarCommand; }
            set { agregarCommand = value; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string NombrePropiedad = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NombrePropiedad));
            }

        }


    }

}

