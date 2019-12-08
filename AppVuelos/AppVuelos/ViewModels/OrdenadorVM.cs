using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using AppVuelos.Model;

namespace AppVuelos.ViewModels
{
    public class OrdenadorVM:INotifyPropertyChanged
    {

        public OrdenadorVM()
        {
            PickerP = dt.PickerAdd();
            PCompania = dt.PCompaniaAdd();
            PEscala = dt.PEscalaAdd();
            PHs = dt.PHsAdd();
            PMin = dt.PMinAdd();
        }





        private List<PickerList> selectedllegadaminv;

        public List<PickerList> SeletedLlegadaMinV
        {
            get { return selectedllegadaminv; }
            set { selectedllegadaminv = value; }
        }



        private List<PickerList> selectedllegadahsv;

        public List<PickerList> SelectedLlegadaHsV
        {
            get { return selectedllegadahsv; }
            set { selectedllegadahsv = value; }
        }



        private List<PickerList> selectedsalidaminv;

        public List<PickerList> SelectedSalidaMinV
        {
            get { return selectedsalidaminv; }
            set { selectedsalidaminv = value; }
        }


        private List<PickerList> selectedSalidaHsv;

        public List<PickerList> SelectedSalidaHsV
        {
            get { return selectedSalidaHsv; }
            set { selectedSalidaHsv = value; }
        }








        private List<PickerList> selectedllegadamin;

        public List<PickerList> SeletedLlegadaMin
        {
            get { return selectedllegadamin; }
            set { selectedllegadamin = value; }
        }



        private List<PickerList> selectedllegadahs;

        public List<PickerList> SelectedLlegadaHs
        {
            get { return selectedllegadahs; }
            set { selectedllegadahs = value; }
        }



        private List<PickerList> selectedsalidamin;

        public List<PickerList> SelectedSalidaMin
        {
            get { return selectedsalidamin; }
            set { selectedsalidamin = value; }
        }


        private List<PickerList> selectedSalidaHs;

        public List<PickerList> SelectedSalidaHs
        {
            get { return selectedSalidaHs; }
            set { selectedSalidaHs = value; }
        }


        private List<PickerList> selectedescala;

        public List<PickerList> SelectedEscala
        {
            get { return selectedescala; }
            set { selectedescala = value; }
        }



        private List<PickerList> selectedpcia;

        public List<PickerList> SelectedPCia
        {
            get { return selectedpcia; }
            set { selectedpcia = value; }
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
            get { return datellegada; }
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

