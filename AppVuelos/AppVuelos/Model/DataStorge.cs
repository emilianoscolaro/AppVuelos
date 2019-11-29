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
                new Destino(){Name ="Dominicana"},
                new Destino(){Name ="E.E.U.U."},
                new Destino(){Name ="Brasil"},
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


        public List<Ciudad> GetCiudadesEEUU()
        {
            var ciudades = new List<Ciudad>()
            {
                new Ciudad(){Name ="San Francisco"},
                new Ciudad(){Name ="Miami"},
                new Ciudad(){Name ="New York"},
                new Ciudad(){Name ="Los Angeles"},
            };
            return ciudades;
        }

        public List<Ciudad> GetCiudadesPUJ()
        {
            var ciudades = new List<Ciudad>()
            {
                new Ciudad(){Name ="Punta Cana"},
                new Ciudad(){Name ="Bayahibe"},
                new Ciudad(){Name ="La Romana"},
            };
            return ciudades;
        }


        public List<Ciudad> GetCiudadesBrasil()
        {
            var ciudades = new List<Ciudad>()
            {
                new Ciudad(){Name ="Rio"},
                new Ciudad(){Name ="Sao Pablo"},
                new Ciudad(){Name ="Buzios"},
                new Ciudad(){Name ="Salbador"},
                new Ciudad(){Name ="Florianopolis"},
                new Ciudad(){Name ="Recife"},
            };
            return ciudades;
        }













        /// <summary>
        /// ///////////////////////////////
        /// </summary>
        /// <returns></returns>



            public List<Hotel> GetHotelesVaradero()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="1",},
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
                if (ciudad == "Dominicana")
                    lista = datastorge.GetCiudadesColombia();
                if (ciudad == "E.E.U.U.")
                    lista = datastorge.GetCiudadesColombia();
                if (ciudad == "Brasil")
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
                if (ciudad == "La Habana")
                    lista = datastorge.GetHotelesHabana();
            }
            return lista;
    
        }




    }

}
