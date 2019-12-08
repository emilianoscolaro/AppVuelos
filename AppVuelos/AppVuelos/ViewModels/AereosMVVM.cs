using System;
using System.Collections.Generic;
using System.Text;
using AppVuelos.Model;
using Xamarin.Forms;

namespace AppVuelos.ViewModels
{
    public class AereosMVVM 
    {


        string _precio;
        Model.PickerList _pick;
        bool _checktransfer;
        bool _ckvalija;
        bool _ckbolso;
        bool _cktrasladocasa;
        DateTime _salida;
        DateTime _llegada;
        Model.PickerList _cia;
        Model.PickerList _escala;
        Model.PickerList _shs;
        Model.PickerList _shsv;
        Model.PickerList _lhs;
        Model.PickerList _lhsv;
        Model.PickerList _smin;
        Model.PickerList _sminv;
        Model.PickerList _lmin;
        Model.PickerList _lminv;


        public AereosMVVM(Model.PickerList Pick, string Precio, bool CheckTransfer, bool CkBolso, bool CkTrasladoCasa, bool CkValija,
           DateTime Salida, DateTime Llegada, Model.PickerList Cia, Model.PickerList Escala, Model.PickerList Shs, Model.PickerList ShsV, Model.PickerList Lhs
            , Model.PickerList LhsV, Model.PickerList Smin, Model.PickerList SminV, Model.PickerList Lmin, Model.PickerList LminV)
        {

            _pick = Pick;
            _precio = Precio;
            _checktransfer = CheckTransfer;
            _ckbolso = CkBolso;
            _ckvalija = CkValija;
            _cktrasladocasa = CkTrasladoCasa;
            _salida = Salida;
            _llegada = Llegada;
            _cia = Cia;
            _escala = Escala;
            _shs = Shs;
            _shsv = ShsV;
            _lhs = Lhs;
            _lhsv = LhsV;
            _smin = Smin;
            _sminv = SminV;
            _lmin = Lmin;
            _lminv = LminV;


        }


        private string lminv;

        public string LMinV
        {
            get { return _lminv.Minutos; }
            set { _lminv.Minutos = value; }
        }

        private string lmin;

        public string LMin
        {
            get { return _lmin.Minutos; }
            set { _lmin.Minutos = value; }
        }


        private string sminv;

        public string SminV
        {
            get { return _sminv.Minutos; }
            set { _sminv.Minutos = value; }
        }

        private string smin;

        public string Smin
        {
            get { return _smin.Minutos; }
            set { _smin.Minutos = value; }
        }



        private string lhsv;

        public string LhsV
        {
            get { return _lhsv.Hora; }
            set { _lhsv.Hora = value; }
        }

        private string lhs;

        public string Lhs
        {
            get { return _lhs.Hora; }
            set { _lhs.Hora = value; }
        }



        private string shsv;

        public string ShsV
        {
            get { return _shsv.Hora; }
            set { _shsv.Hora = value; }
        }

        private string shs;

        public string Shs
        {
            get { return _shs.Hora; }
            set { _shs.Hora = value; }
        }


        private string escalas;

        public string Escalas
        {
            get { return _escala.Escalas; }
            set { _escala.Escalas = value; }
        }



        private string compania;

        public string Cia
        {
            get { return _cia.Compania; }
            set { _cia.Compania = value; }
        }



        private DateTime llegada;

        public DateTime Llegada
        {
            get { return _llegada; }
            set { _llegada = value; }
        }



        private DateTime salida;

        public DateTime Salida
        {
            get { return _salida; }
            set { _salida = value; }
        }



        private bool isvisiblea;

        public bool IsVisiblEA
        {
            get { return isvisiblea; }
            set { isvisiblea = value; }
        }

        private bool isvisibleb;

        public bool IsVisibleB
        {
            get { return isvisibleb; }
            set { isvisibleb = value; }
        }

        private bool isvisiblec;

        public bool IsVisibleC
        {
            get { return isvisiblec; }
            set { isvisiblec = value; }
        }


        private bool isvisibled;

        public bool IsVisibleD
        {
            get { return isvisibled; }
            set { isvisibled = value; }
        }


        private bool isvisiblee;

        public bool IsVisibleE
        {
            get { return isvisiblee; }
            set { isvisiblee = value; }
        }





        private string __checkbolso;

        public string CkBolso
        {
            get
            {
                if (_ckbolso == true)
                {
                    __checkbolso = "*Con bolso de mano";
                    isvisibleb = true;
                }

                return __checkbolso;
            }
            set { }
        }

        private string __checkvalija;

        public string CKValija
        {
            get
            {
                if (_ckvalija == true)
                {
                    __checkvalija = "*Con valija en bodega";
                    isvisiblec = true;
                }

                return __checkvalija;
            }
            set { }
        }

        private string __checktransfercasa;

        public string CKTransfercasa
        {
            get
            {
                if (_cktrasladocasa == true)
                {
                    __checktransfercasa = "*Transfer Domicilio/Aeropuerto";
                    isvisibled = true;
                }

                return __checktransfercasa;
            }
            set { }
        }




        private string _check;

        public string _CheckTransfer
        {
            get
            {
                if (_checktransfer == true)
                {
                    _check = "*Trasnsfer IN/OUT";
                    isvisiblee = true;
                }

                return _check;
            }
            set { }
        }


        private string __precio;

        public string Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        private string _pickleyenda;

        public string PickLeyenda
        {
            get { return _pick.Leyenda; }
            set { _pick.Leyenda = value; }
        }

        private string _pickprecio;

        public string PickPrecio
        {
            get { return _pick.Precio; }
            set { _pick.Precio = value; }
        }



    }
}
