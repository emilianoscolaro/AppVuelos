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

        private void OnPropertyChanged([CallerMemberName] string NombrePropiedad = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NombrePropiedad));
            }

        }

        public PaquetePreviaMVVM()
        {
            DestinosList = datastorge.GetDestinos();
            OnPropertyChanged();

        }

        
        private Destino selectdestino;

        public Destino SelectDestino
        {
            get { return selectdestino;}
            set { selectdestino = value; 
                if (value == null)
                {
                    VisCiudad = false;
                }
                else
                {
                    VisCiudad = true;
                    
                }
                CiudadesList= datastorge.Ciudadidentify(selectdestino.Name, CiudadesList);
                OnPropertyChanged();
            }
        }

        private Ciudad selectciudad;

        public Ciudad SelectCiudad
        {
            get { return selectciudad; }
            set{ selectciudad = value;
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
            set { vishotel = value;OnPropertyChanged(); }
        }




        DataStorge datastorge = new DataStorge();

        private List<Destino> destinoslist;

        public List<Destino> DestinosList
        {
            get { return destinoslist; }
            set { destinoslist = value;OnPropertyChanged(); }
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
            set { hoteleslist = value;OnPropertyChanged(); }
        }



    }


}
