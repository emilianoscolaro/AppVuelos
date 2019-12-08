﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AppVuelos.Model
{
    class DataStorge
    {


        public List<Destino> GetDestinos()
        {
            var destinos = new List<Destino>()
            {
                new Destino(){Name ="Cuba  ",Foto ="cuba.png" },
                new Destino(){Name ="Dominicana  ",Foto="punta_cana"},
                new Destino(){Name ="E.E.U.U.  ",Foto ="usa"},
                new Destino(){Name ="Brasil  ",Foto="brasil"},
                new Destino(){Name ="Colombia  ",Foto="colombia"},
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
                new Hotel(){Name ="Iberostar Selection Varadero",},
                new Hotel(){Name ="Blau Varadero"},
                new Hotel(){Name ="Meliá Varadero"},
                new Hotel(){Name ="Sol Palmeras Hotel"},

            };
            return hoteles;
        }

        public List<Hotel> GetHotelesHabana()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Hotel NH Capri La Habana"},
                new Hotel(){Name ="Iberostar Parque Central"},
                new Hotel(){Name ="Elegancia Suites Habana"},
                new Hotel(){Name ="La Reserva Vedado"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesCayoGuillermo()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Sercotel Club Cayo Guillermo"},
                new Hotel(){Name ="Sol Cayo Guillermo"},
                new Hotel(){Name ="Iberostar Daiquiri"},
                new Hotel(){Name ="Iberostar Selection Playa Pilar"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesCayoSMaria()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Meliá Cayo Santa María"},
                new Hotel(){Name ="Sol Cayo Santa María All Inclusive"},
                new Hotel(){Name ="Playa Cayo Santa Maria"},
                new Hotel(){Name ="Ocean Casa Del Mar"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesCayococo()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Hotel Colonial Cayo Coco"},
                new Hotel(){Name ="Hotel Tryp Cayo Coco"},
                new Hotel(){Name ="Iberostar Mojito"},
                new Hotel(){Name ="Melia Cayo Coco"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesCartagena()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Hostal Republica Cartagena"},
                new Hotel(){Name ="Ibis Hotel Cartagena"},
                new Hotel(){Name ="Hilton Cartagena"},
                new Hotel(){Name ="Casa India Catalina"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesSanAndres()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Hotel Sea Horse"},
                new Hotel(){Name ="GHL Relax Hotel Sunrise"},
                new Hotel(){Name ="Hotel San Luis Place"},
                new Hotel(){Name ="Hotel Cocoplum Beach"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesSantaMarta()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Hotel Sea Horse"},
                new Hotel(){Name ="GHL Relax Hotel Sunrise"},
                new Hotel(){Name ="Hotel San Luis Place"},
                new Hotel(){Name ="Hotel Cocoplum Beach"},

            };
            return hoteles;

        }











        public List<Hotel> Hoteldidentify(string ciudad, List<Hotel> lista)
        {
            DataStorge datastorge = new DataStorge();
            if (ciudad != null)
            {
                if (ciudad == "Varadero")
                    lista = datastorge.GetHotelesVaradero().OrderBy(t => t.Name).ToList();
                if (ciudad == "La Habana")
                    lista = datastorge.GetHotelesHabana().OrderBy(t => t.Name).ToList();
                if (ciudad == "Cayo Guillermo")
                    lista = datastorge.GetHotelesCayoGuillermo().OrderBy(t => t.Name).ToList();
                if (ciudad == "Cayo Santa Maria")
                    lista = datastorge.GetHotelesCayoSMaria().OrderBy(t => t.Name).ToList();
                if (ciudad == "Cayo Coco")
                    lista = datastorge.GetHotelesCayococo().OrderBy(t => t.Name).ToList();
                if (ciudad == "Cartagena")
                    lista = datastorge.GetHotelesCartagena().OrderBy(t => t.Name).ToList();
                if (ciudad == "San andres")
                    lista = datastorge.GetHotelesSanAndres().OrderBy(t => t.Name).ToList();






            }
            return lista;

        }


        public List<Ciudad> Ciudadidentify(string ciudad,List<Ciudad> lista)
        {
            DataStorge datastorge = new DataStorge();
            if(ciudad != null)
            {
                if (ciudad == "Cuba  ")
                    lista = datastorge.GetCiudadesCuba().OrderBy(t => t.Name).ToList();
                if (ciudad == "Colombia  ")
                    lista = datastorge.GetCiudadesColombia().OrderBy(t => t.Name).ToList();
                if (ciudad == "Dominicana  ")
                    lista = datastorge.GetCiudadesPUJ().OrderBy(t => t.Name).ToList();
                if (ciudad == "E.E.U.U.  ")
                    lista = datastorge.GetCiudadesEEUU().OrderBy(t => t.Name).ToList();
                if (ciudad == "Brasil  ")
                    lista = datastorge.GetCiudadesBrasil().OrderBy(t => t.Name).ToList();
            }
            else
            {
                lista = null;
            }
            return lista;
        }











        public List<PickerList> PEscalaAdd()
        {
            var picker = new List<PickerList>()
            {
                new PickerList(){ Escalas ="Directo"},
                new PickerList(){ Escalas ="Una escala"},
                new PickerList(){ Escalas ="Dos escalas"},

            };


            return picker;
        }

        public List<PickerList> PMinAdd()
        {
            var picker = new List<PickerList>()
            {

                new PickerList(){ Minutos ="00"},
                new PickerList(){ Minutos ="01"},
                new PickerList(){ Minutos ="02"},
                new PickerList(){ Minutos ="03"},
                new PickerList(){ Minutos ="04"},
                new PickerList(){ Minutos ="05"},
                new PickerList(){ Minutos ="06"},
                new PickerList(){ Minutos ="07"},
                new PickerList(){ Minutos ="08"},
                new PickerList(){ Minutos ="09"},
                new PickerList(){ Minutos ="10"},
                new PickerList(){ Minutos ="11"},
                new PickerList(){ Minutos ="12"},
                new PickerList(){ Minutos ="13"},
                new PickerList(){ Minutos ="14"},
                new PickerList(){ Minutos ="15"},
                new PickerList(){ Minutos ="16"},
                new PickerList(){ Minutos ="17"},
                new PickerList(){ Minutos ="18"},
                new PickerList(){ Minutos ="19"},
                new PickerList(){ Minutos ="20"},
                new PickerList(){ Minutos ="21"},
                new PickerList(){ Minutos ="22"},
                new PickerList(){ Minutos ="23"},
                new PickerList(){ Minutos ="24"},
                new PickerList(){ Minutos ="25"},
                new PickerList(){ Minutos ="26"},
                new PickerList(){ Minutos ="27"},
                new PickerList(){ Minutos ="28"},
                new PickerList(){ Minutos ="29"},
                new PickerList(){ Minutos ="30"},
                new PickerList(){ Minutos ="31"},
                new PickerList(){ Minutos ="32"},
                new PickerList(){ Minutos ="33"},
                new PickerList(){ Minutos ="34"},
                new PickerList(){ Minutos ="35"},
                new PickerList(){ Minutos ="36"},
                new PickerList(){ Minutos ="37"},
                new PickerList(){ Minutos ="38"},
                new PickerList(){ Minutos ="39"},
                new PickerList(){ Minutos ="40"},
                new PickerList(){ Minutos ="41"},
                new PickerList(){ Minutos ="42"},
                new PickerList(){ Minutos ="43"},
                new PickerList(){ Minutos ="44"},
                new PickerList(){ Minutos ="45"},
                new PickerList(){ Minutos ="46"},
                new PickerList(){ Minutos ="47"},
                new PickerList(){ Minutos ="48"},
                new PickerList(){ Minutos ="49"},
                new PickerList(){ Minutos ="50"},
                new PickerList(){ Minutos ="51"},
                new PickerList(){ Minutos ="52"},
                new PickerList(){ Minutos ="53"},
                new PickerList(){ Minutos ="54"},
                new PickerList(){ Minutos ="55"},
                new PickerList(){ Minutos ="56"},
                new PickerList(){ Minutos ="57"},
                new PickerList(){ Minutos ="58"},
                new PickerList(){ Minutos ="59"},

            };


            return picker;
        }



        public List<PickerList> PHsAdd()
        {
            List<PickerList> picker = new List<PickerList>()
            {
                new PickerList(){  Hora ="00"},
                new PickerList(){  Hora ="01"},
                new PickerList(){  Hora ="02"},
                new PickerList(){  Hora ="03"},
                new PickerList(){  Hora ="04"},
                new PickerList(){  Hora ="05"},
                new PickerList(){  Hora ="06"},
                new PickerList(){  Hora ="07"},
                new PickerList(){  Hora ="08"},
                new PickerList(){  Hora ="09"},
                new PickerList(){  Hora ="10"},
                new PickerList(){  Hora ="11"},
                new PickerList(){  Hora ="12"},
                new PickerList(){  Hora ="13"},
                new PickerList(){  Hora ="14"},
                new PickerList(){  Hora ="15"},
                new PickerList(){  Hora ="16"},
                new PickerList(){  Hora ="17"},
                new PickerList(){  Hora ="18"},
                new PickerList(){  Hora ="19"},
                new PickerList(){  Hora ="20"},
                new PickerList(){  Hora ="21"},
                new PickerList(){  Hora ="22"},
                new PickerList(){  Hora ="23"},
            };


            return picker;
        }



        public List<PickerList> PCompaniaAdd()
        {
            var picker = new List<PickerList>()
            {
                new PickerList(){ Compania ="Aerolineas Argentinas"},
                new PickerList(){ Compania ="Aero Mexico"},
                new PickerList(){ Compania ="Air Europa"},
                new PickerList(){ Compania ="Air France"},
                new PickerList(){ Compania ="Alitalia"},
                new PickerList(){ Compania ="American Airlines"},
                new PickerList(){ Compania ="Avianca"},
                new PickerList(){ Compania ="British"},
                new PickerList(){ Compania ="Copa"},
                new PickerList(){ Compania ="Delta"},
                new PickerList(){ Compania ="Emirates"},
                new PickerList(){ Compania ="Gol"},
                new PickerList(){ Compania ="Iberia"},
                new PickerList(){ Compania ="KLM"},
                new PickerList(){ Compania ="Lan"},
                new PickerList(){ Compania ="Lufthansa"},
                new PickerList(){ Compania ="Norwegian"},
                new PickerList(){ Compania ="Quatar"},
                new PickerList(){ Compania ="Turquish"},
                new PickerList(){ Compania ="United Air"},
            };


            return picker;
        }




        public List<PickerList> PickerAdd()
        {
            var picker = new List<PickerList>()
            {
                new PickerList(){Precio ="U$D",Leyenda ="Precio por PAX"},
                new PickerList(){Precio ="AR$",Leyenda ="Precio por paquete"},
            };


            return picker;
        }


        


    }

}
