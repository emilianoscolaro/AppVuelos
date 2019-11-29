using System;
using System.Collections.Generic;
using System.Text;

namespace AppVuelos.Model
{
    class DataStorge
    {
        public List<Destino> GetDestinos()
        {
            var destinos = new List<Destino>()
            {
                new Destino(){Name ="Cuba"},
                new Destino(){Name ="Punta Cana"},
                new Destino(){Name ="E.E.U.U."},
                new Destino(){Name ="Brazil"},
                new Destino(){Name ="Colombia"},
            };
            return destinos;
        }


        public List<Ciudad> GetCiudadesCuba()
        {
            var ciudades = new List<Ciudad>()
            {
                new Ciudad(){Name ="Varadero"},
                new Ciudad(){Name ="Cayo Guillermo"},
                new Ciudad(){Name ="Cayo Santa Maria"},
                new Ciudad(){Name ="Cayo Coco"},
                new Ciudad(){Name ="La Habana"},
            };
            return ciudades;
        }


        public List<Ciudad> GetCiudadesColombia()
        {
            var ciudades = new List<Ciudad>()
            {
                new Ciudad(){Name ="Cartagena"},
                new Ciudad(){Name ="San andres"},
                new Ciudad(){Name ="Santa Marta"},
            };
            return ciudades;
        }


        public List<Hotel> GetHotelesVaradero()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="1"},
                new Hotel(){Name ="2"},
                new Hotel(){Name ="3"},
                new Hotel(){Name ="4"},

            };
            return hoteles;
        }

        public List<Hotel> GetHotelesHabana()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="H1"},
                new Hotel(){Name ="H2"},
                new Hotel(){Name ="H3"},
                new Hotel(){Name ="H4"},

            };
            return hoteles;

        }


        public List<Ciudad> Ciudadidentify(string ciudad,List<Ciudad> lista)
        {
            DataStorge datastorge = new DataStorge();
            if(ciudad != null)
            {
                if (ciudad == "Cuba")
                    lista = datastorge.GetCiudadesCuba();
                if (ciudad == "Colombia")
                    lista = datastorge.GetCiudadesColombia();
            }
            else
            {
                lista = null;
            }
            return lista;
        }

        public List<Hotel> Hoteldidentify(string ciudad, List<Hotel> lista)
        {
            DataStorge datastorge = new DataStorge();
            if (ciudad != null)
            {
                if (ciudad == "Varadero")
                    lista = datastorge.GetHotelesVaradero();
                if (ciudad == "Habana")
                    lista = datastorge.GetHotelesHabana();
            }
            else
            {
                lista = null;
            }
            return lista;
        }
    }
}
