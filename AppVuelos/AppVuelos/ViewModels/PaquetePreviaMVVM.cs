using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using AppVuelos.Model;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Linq;

namespace AppVuelos.ViewModels
{
    public class PaquetePreviaMVVM : INotifyPropertyChanged 
    {
        public PaquetePreviaMVVM(INavigation navigation)
        {
            DestinosList = datastorge.GetDestinos().OrderBy(t =>t.Name).ToList();
            PCompania = datastorge.PCompaniaAdd();
            PEscala = datastorge.PEscalaAdd();
            PHs = datastorge.PHsAdd();
            PMin = datastorge.PMinAdd();
            PickerP = datastorge.PickerAdd();
            PAeropuerto = datastorge.PickAeropuertos();
            this.Navigation = navigation;
            this.Agregar = new Command(async () => await GotoPPage());
            this.SiguienteBtn = new Command(async () => await GotoPPageAereos());
            OnPropertyChanged();
            

        }


        public INavigation Navigation { get; set; }

        private PickerList selectedllegadaminv;

        public PickerList SeletedLlegadaMinV
        {
            get { return selectedllegadaminv; }
            set { selectedllegadaminv = value; }
        }



        private PickerList selectedllegadahsv;

        public PickerList SelectedLlegadaHsV
        {
            get { return selectedllegadahsv; }
            set { selectedllegadahsv = value; }
        }



        private PickerList selectedsalidaminv;

        public PickerList SelectedSalidaMinV
        {
            get { return selectedsalidaminv; }
            set { selectedsalidaminv = value; }
        }


        private PickerList selectedSalidaHsv;

        public PickerList SelectedSalidaHsV
        {
            get { return selectedSalidaHsv; }
            set { selectedSalidaHsv = value; }
        }








        private PickerList selectedllegadamin;

        public PickerList SeletedLlegadaMin
        {
            get { return selectedllegadamin; }
            set { selectedllegadamin = value; }
        }



        private PickerList selectedllegadahs;

        public PickerList SelectedLlegadaHs
        {
            get { return selectedllegadahs; }
            set { selectedllegadahs = value; }
        }



        private PickerList selectedsalidamin;

        public PickerList SelectedSalidaMin
        {
            get { return selectedsalidamin; }
            set { selectedsalidamin = value; }
        }


        private PickerList selectedSalidaHs;

        public PickerList SelectedSalidaHs
        {
            get { return selectedSalidaHs; }
            set { selectedSalidaHs = value; }
        }


        private PickerList selectedescala;

        public PickerList SelectedEscala
        {
            get { return selectedescala; }
            set { selectedescala = value; }
        }



        private PickerList selectedpcia;

        public PickerList SelectedPCia
        {
            get { return selectedpcia; }
            set { selectedpcia = value; }
        }

        private PickerList selectedescalav;

        public PickerList SelectedEscalaV
        {
            get { return selectedescalav; }
            set { selectedescalav = value; }
        }



        private PickerList selectedpciav;

        public PickerList SelectedPCiaV
        {
            get { return selectedpciav; }
            set { selectedpciav = value; }
        }

        private List<PickerList> pmin;

        public List<PickerList> PMin
        {
            get { return pmin; }
            set { pmin = value; }
        }

        private List<PickerList> phs;

        public List<PickerList> PHs
        {
            get { return phs; }
            set { phs = value; }
        }

        private List<PickerList> pescala;

        public List<PickerList> PEscala
        {
            get { return pescala; }
            set { pescala = value; }
        }



        private List<PickerList> pcompania;

        public List<PickerList> PCompania
        {
            get { return pcompania; }
            set { pcompania = value; }
        }



        DataStorge dt = new DataStorge();

        private DateTime datellegada;

        public DateTime DateLlegada
        {
            get { return datellegada; }
            set
            {
                if (datellegada == DateTime.Today)
                {
                    datellegada = value;
                }
                else
                {
                    datellegada = DateTime.Today;
                    OnPropertyChanged();
                }

            }
        }


        private DateTime datesalida;

        public DateTime DateSalida
        {
            get { return datesalida; }
            set
            {
                if (datesalida == DateTime.Today)
                {
                    datesalida = value;
                }
                else
                {
                    datesalida = DateTime.Today;
                    OnPropertyChanged();
                }

            }

        }



        private Destino selectdestino;

        public Destino SelectDestino
        {
            get { return selectdestino; }
            set { selectdestino = value;

                if (value != null)
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
            set { if(value != null)
                {
                    selectciudad = value;
                    if (value != null)
                    {
                        VisHotel = true;
                    }
                    HotelesList = datastorge.Hoteldidentify(selectciudad.Name, HotelesList);
                    OnPropertyChanged();
                }
                    



            }
        }

        private Hotel selectedhotel;

        public Hotel SelectedHotel
        {
            get { return selectedhotel; }
            set { selectedhotel = value; }
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


        private Command siguientebtn;

        public Command SiguienteBtn
        {
            get { return siguientebtn; }
            set { siguientebtn = value; }
        }



        public async Task GotoPPage()
        {
            if(SelectDestino !=null && SelectDestino!= null && SelectedPick != null && Precio != null && DateSalida != null && DateLlegada != null &&
               SelectedPCia != null && SelectedEscala != null && SelectedSalidaHs != null && SelectedSalidaHsV != null && SelectedLlegadaHs != null
               && SelectedLlegadaHsV != null && SelectedSalidaMin != null && SelectedSalidaMinV != null && SeletedLlegadaMin != null && SeletedLlegadaMin != null)
            {
                await Navigation.PushAsync(new PaquetePage(SelectDestino, SelectedHotel, SelectedPick, Precio, ChekTransf, CkAsistencia, CkBolso, CkTrasladoCasa, CkValija
              , DateSalida, DateLlegada, SelectedPCia, SelectedEscala, SelectedSalidaHs, SelectedSalidaHsV, SelectedLlegadaHs, SelectedLlegadaHsV,
                SelectedSalidaMin, SelectedSalidaMinV, SeletedLlegadaMin, SeletedLlegadaMinV));
            }
            else
            {
                HayError = true;
            }
            

        }


        public async Task GotoPPageAereos()
        {
            if (SelectedPick != null && Precio != null && DateSalida != null && DateLlegada != null &&
               SelectedPCia != null && SelectedEscala != null && SelectedSalidaHs != null && SelectedSalidaHsV != null && SelectedLlegadaHs != null
               && SelectedLlegadaHsV != null && SelectedSalidaMin != null && SelectedSalidaMinV != null && SeletedLlegadaMin != null && SeletedLlegadaMin != null)
            {
                await Navigation.PushAsync(new Aereos(SelectedPick, Precio, ChekTransf, CkBolso, CkTrasladoCasa, CkValija
              , DateSalida, DateLlegada, SelectedPCia, SelectedEscala, SelectedSalidaHs, SelectedSalidaHsV, SelectedLlegadaHs, SelectedLlegadaHsV,
                SelectedSalidaMin, SelectedSalidaMinV, SeletedLlegadaMin, SeletedLlegadaMinV, SelectedPAIda,SelectedPAIdaV,SelectedPAVueltaI,SelectedPAVuelta, SelectedPCiaV, SelectedEscalaV));
            }
            else
            {
                HayError = true;
            }


        }


        private Aeropuerto selectedpaeropuerto;

        public Aeropuerto SelectedPAIda
        {
            get { return selectedpaeropuerto; }
            set { selectedpaeropuerto = value; }
        }

        private Aeropuerto selectedpaeropuertoiv;

        public Aeropuerto SelectedPAIdaV
        {
            get { return selectedpaeropuertoiv; }
            set { selectedpaeropuertoiv = value; }
        }
        private Aeropuerto selectedpaeropuertovuelta;

        public Aeropuerto SelectedPAVueltaI
        {
            get { return selectedpaeropuertovuelta; }
            set { selectedpaeropuertovuelta = value; }
        }
        private Aeropuerto selectedpaeropuertovueltav;

        public Aeropuerto SelectedPAVuelta
        {
            get { return selectedpaeropuertovueltav; }
            set { selectedpaeropuertovueltav = value; }
        }



        private bool hayerror;

        public bool HayError
        {
            get { return hayerror; }
            set { hayerror = value;OnPropertyChanged(); }
        }





        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string NombrePropiedad = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NombrePropiedad));
            }

        }


        private string precio;

        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }



        /////////Check//////////


        private bool checktransf;

        public bool ChekTransf
        {
            get { return checktransf; }
            set { checktransf = value;OnPropertyChanged(); }
        }

        private bool ckAsistencia;

        public bool CkAsistencia
        {
            get { return ckAsistencia; }
            set { ckAsistencia = value; OnPropertyChanged(); }
        }

        private bool ckValija;

        public bool CkValija
        {
            get { return ckValija; }
            set { ckValija = value; OnPropertyChanged(); }
        }

        private bool ckBolso;

        public bool CkBolso
        {
            get { return ckBolso; }
            set { ckBolso = value; OnPropertyChanged(); }
        }

        private bool ckTrasladoCasa;

        public bool CkTrasladoCasa
        {
            get { return ckTrasladoCasa; }
            set { ckTrasladoCasa = value; OnPropertyChanged(); }
        }

        //////// PIKERS////////



        private List<Aeropuerto> paeropuerto;

        public List<Aeropuerto> PAeropuerto
        {
            get { return paeropuerto; }
            set { paeropuerto = value; }
        }




        private List<PickerList> pickerp;

        public List<PickerList> PickerP
        {
            get { return pickerp; }
            set { pickerp = value; }
        }

        private PickerList selectedpick;

        public PickerList SelectedPick
        {
            get { return selectedpick; }
            set { selectedpick = value; }
        }



    }


}

