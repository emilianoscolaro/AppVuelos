using System;
using System.Collections.Generic;
using System.Text;
using AppVuelos.Model;
using Xamarin.Forms;

namespace AppVuelos.ViewModels
{
    public class PaquetePageMVVM
    {
        Model.Destino _item;
        Model.Hotel _itemH;
        string _precio;
        Model.PickerList _pick;
        public PaquetePageMVVM(Model.Destino item,Model.Hotel Hitem,Model.PickerList Pick,string Precio)
        {
            _item = item;
            _itemH = Hitem;
            _pick = Pick;
            _precio = Precio;
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


        private string _destinoimage;

        public string DestinoImage
        {
            get { return _item.Foto; }
            set { _item.Foto= value; }
        }


        private string _destino;

        public string DestinoNombre
        {
            get { return _item.Name; }
            set { _item.Name = value; }
        }


        private string _hotel;

        public string HotelNombre
        {
            get { return _itemH.Name; }
            set { _itemH.Name = value; }
        }





    }
}
