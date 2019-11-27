using System;
using System.Collections.Generic;
using System.Text;

namespace AppVuelos.Model
{
    class DataStorge
    {
        public List<Destino> GetDestinosCuba()
        {
            var destinos = new List<Destino>()
            {
                new Destino(){Name ="Cuba"},
                new Destino(){City  ="Baradero"},
                new Destino(){City  ="Cayo Coco"},
                new Destino(){City  ="Cayo Guillermo"},
                new Destino(){Hotels  ="Cayo Guillermo"},

            };
            return destinos;
        }


    }
}
