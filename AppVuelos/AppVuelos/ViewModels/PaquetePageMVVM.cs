using System;
using System.Collections.Generic;
using System.Text;
using AppVuelos.Model;

namespace AppVuelos.ViewModels
{
    public class PaquetePageMVVM
    {
        Model.Destino _item;
        Model.Hotel _itemH;
        public PaquetePageMVVM(Model.Destino item)
        {
            _item = item;
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
