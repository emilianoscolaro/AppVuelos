using System;
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

        public List<Hotel> GetHotelesSanFrancisco()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="HI San Francisco Downtown Hostel"},
                new Hotel(){Name ="Americania Hotel"},
                new Hotel(){Name ="Cable Car Hotel"},
                new Hotel(){Name ="Casa Loma Hotel"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesMiami()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Hostel Brazilian"},
                new Hotel(){Name ="Ocean Five Hotel"},
                new Hotel(){Name ="Old Cottage House"},
                new Hotel(){Name ="Novotel Miami Brickell"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesNewYork()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Four Seasons Hotel New York"},
                new Hotel(){Name ="The Brooklyn Riviera Hostel"},
                new Hotel(){Name ="Q4 Hotel"},
                new Hotel(){Name ="Hotel Plaza"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesLosAngeles()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Libra Hotel"},
                new Hotel(){Name ="Los Angeles Vacation Rooms"},
                new Hotel(){Name ="Banana Bungalow Hollywood"},
                new Hotel(){Name ="El Royale Hotel"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesPuntaCana()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Occidental Punta Cana"},
                new Hotel(){Name ="Tropical Princess Beach Resort & Spa"},
                new Hotel(){Name ="Karibo Punta Cana"},
                new Hotel(){Name ="El Royale HIberostar Selection Bavarootel"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesBayahibe()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Be Live Collection Canoa"},
                new Hotel(){Name ="Iberostar Hacienda Dominicus"},
                new Hotel(){Name ="Dreams Dominicus La Romana"},
                new Hotel(){Name ="Catalonia Gran Dominicus"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesRio()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="LEME - COPACABANA"},
                new Hotel(){Name ="Selina Lapa Rio de Janeiro"},
                new Hotel(){Name ="HOTEL MERLIN"},
                new Hotel(){Name ="Windsor Martinique Hotel"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesSaoPablo()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Hotel Novotel Sao Paulo Jaragua Conventions"},
                new Hotel(){Name ="Braston Hotel São Paulo"},
                new Hotel(){Name ="ibis budget São Paulo São João"},
                new Hotel(){Name ="Radisson Paulista Plaza"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesBuzios()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Hotel Ilha Branca Inn"},
                new Hotel(){Name ="Atlântico Búzios"},
                new Hotel(){Name ="Buzios Centro Hotel"},
                new Hotel(){Name ="Latitud Buzios"},

            };
            return hoteles;

        }

        public List<Hotel> GetHotelesSalvador()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Village Paraíso Tropical"},
                new Hotel(){Name ="Patachocas"},
                new Hotel(){Name ="Pousada Vila das Pedras"},
                new Hotel(){Name ="Villa Dos Graffitis Pousada"},

            };
            return hoteles;

        }


        public List<Hotel> GetHotelesFloria()
        {
            var hoteles = new List<Hotel>()
            {
                new Hotel(){Name ="Canasvieiras Internacional"},
                new Hotel(){Name ="Luisa Palace Hotel"},
                new Hotel(){Name ="Ibis Florianopolis"},
                new Hotel(){Name ="Geranius Praia dos Ingleses"},

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
                if (ciudad == "San Francisco")
                    lista = datastorge.GetHotelesSanFrancisco().OrderBy(t => t.Name).ToList();
                if (ciudad == "Miami")
                    lista = datastorge.GetHotelesMiami().OrderBy(t => t.Name).ToList();
                if (ciudad == "New York")
                    lista = datastorge.GetHotelesNewYork().OrderBy(t => t.Name).ToList();
                if (ciudad == "Los Angeles")
                    lista = datastorge.GetHotelesLosAngeles().OrderBy(t => t.Name).ToList();
                if (ciudad == "Punta Cana")
                    lista = datastorge.GetHotelesPuntaCana().OrderBy(t => t.Name).ToList();
                if (ciudad == "Bayahibe")
                    lista = datastorge.GetHotelesBayahibe().OrderBy(t => t.Name).ToList();
                if (ciudad == "Rio")
                    lista = datastorge.GetHotelesBayahibe().OrderBy(t => t.Name).ToList();
                if (ciudad == "Sao Pablo")
                    lista = datastorge.GetHotelesBayahibe().OrderBy(t => t.Name).ToList();
                if (ciudad == "Buzios")
                    lista = datastorge.GetHotelesBayahibe().OrderBy(t => t.Name).ToList();
                if (ciudad == "Salbador")
                    lista = datastorge.GetHotelesBayahibe().OrderBy(t => t.Name).ToList();
                if (ciudad == "Florianopolis")
                    lista = datastorge.GetHotelesBayahibe().OrderBy(t => t.Name).ToList();






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

        public List<Aeropuerto> PickAeropuertos()
        {
            var picker = new List<Aeropuerto>()
            {
                new Aeropuerto(){Codigo ="BIO"} ,
                new Aeropuerto(){Codigo ="BSL"},
                new Aeropuerto(){Codigo ="BOG"},
                new Aeropuerto(){Codigo ="DAY"},
                new Aeropuerto(){Codigo ="DJE"},
                new Aeropuerto(){Codigo ="DME"},
                new Aeropuerto(){Codigo ="DOH"},
                new Aeropuerto(){Codigo ="DXB"},
                new Aeropuerto(){Codigo ="EAP"},
                new Aeropuerto(){Codigo ="EDI"},
                new Aeropuerto(){Codigo ="EGE"},
                new Aeropuerto(){Codigo ="EIN"},
                new Aeropuerto(){Codigo ="EZE"},
                new Aeropuerto(){Codigo ="ENO"},
                new Aeropuerto(){Codigo ="FAO"},
                new Aeropuerto(){Codigo ="FBD"},
                new Aeropuerto(){Codigo ="FCO"},
                new Aeropuerto(){Codigo ="FDO"},
                new Aeropuerto(){Codigo ="FLR"},
                new Aeropuerto(){Codigo ="FLW"},
                new Aeropuerto(){Codigo ="FMA"},
                new Aeropuerto(){Codigo ="FNC"},
                new Aeropuerto(){Codigo ="FRA"},
                new Aeropuerto(){Codigo ="FRS"},
                new Aeropuerto(){Codigo ="FOR"},
                new Aeropuerto(){Codigo ="GDL"},
                new Aeropuerto(){Codigo ="GHU"},
                new Aeropuerto(){Codigo ="GIB"},
                new Aeropuerto(){Codigo ="GPO"},
                new Aeropuerto(){Codigo ="GRU"},
                new Aeropuerto(){Codigo ="GRW"},
                new Aeropuerto(){Codigo ="GRX"},
                new Aeropuerto(){Codigo ="GUA"},
                new Aeropuerto(){Codigo ="GYE"},
                new Aeropuerto(){Codigo ="HAJ"},
                new Aeropuerto(){Codigo ="HAM"},
                new Aeropuerto(){Codigo ="HAV"},
                new Aeropuerto(){Codigo ="HBX"},
                new Aeropuerto(){Codigo ="HEA"},
                new Aeropuerto(){Codigo ="HEL"},
                new Aeropuerto(){Codigo ="HGL"},
                new Aeropuerto(){Codigo ="HHN​"},
                new Aeropuerto(){Codigo ="HIR"},
                new Aeropuerto(){Codigo ="HKG"},
                new Aeropuerto(){Codigo ="HND"},
                new Aeropuerto(){Codigo ="HNL"},
                new Aeropuerto(){Codigo ="HOR"},
                new Aeropuerto(){Codigo ="HOU"},
                new Aeropuerto(){Codigo ="IBZ"},
                new Aeropuerto(){Codigo ="ICN​"},
                new Aeropuerto(){Codigo ="INV"},
                new Aeropuerto(){Codigo ="IPC"},
                new Aeropuerto(){Codigo ="IRJ"},
                new Aeropuerto(){Codigo ="IST"},
                new Aeropuerto(){Codigo ="IVL"},
                new Aeropuerto(){Codigo ="JAA"},
                new Aeropuerto(){Codigo ="JER"},
                new Aeropuerto(){Codigo ="JFK"},
                new Aeropuerto(){Codigo ="JKL"},
                new Aeropuerto(){Codigo ="JSR"},
                new Aeropuerto(){Codigo ="KBL"},
                new Aeropuerto(){Codigo ="KDH"},
                new Aeropuerto(){Codigo ="KEF"},
                new Aeropuerto(){Codigo ="KGD"},
                new Aeropuerto(){Codigo ="LAD"},
                new Aeropuerto(){Codigo ="LAS"},
                new Aeropuerto(){Codigo ="LAX"},
                new Aeropuerto(){Codigo ="LEU​"},
                new Aeropuerto(){Codigo ="LGG"},
                new Aeropuerto(){Codigo ="LGS"},
                new Aeropuerto(){Codigo ="LHR"},
                new Aeropuerto(){Codigo ="LIM"},
                new Aeropuerto(){Codigo ="LIR"},
                new Aeropuerto(){Codigo ="LIS"},
                new Aeropuerto(){Codigo ="LTN"},
                new Aeropuerto(){Codigo ="LUQ"},
                new Aeropuerto(){Codigo ="MAD"},
                new Aeropuerto(){Codigo ="MCS"},
                new Aeropuerto(){Codigo ="MDE"},
                new Aeropuerto(){Codigo ="MDQ"},
                new Aeropuerto(){Codigo ="MVD"},
                new Aeropuerto(){Codigo ="MDZ"},
                new Aeropuerto(){Codigo ="MEC"},
                new Aeropuerto(){Codigo ="MGA"},
                new Aeropuerto(){Codigo ="MTY"},
                new Aeropuerto(){Codigo ="MEX"},
                new Aeropuerto(){Codigo ="MDX"},
                new Aeropuerto(){Codigo ="MFM"},
                new Aeropuerto(){Codigo ="MIA"},
                new Aeropuerto(){Codigo ="MKC"},
                new Aeropuerto(){Codigo ="MLH"},
                new Aeropuerto(){Codigo ="MLN"},
                new Aeropuerto(){Codigo ="MPN"},
                new Aeropuerto(){Codigo ="MUC"},
                new Aeropuerto(){Codigo ="MXP"},
                new Aeropuerto(){Codigo ="MZR"},
                new Aeropuerto(){Codigo ="MCO"},
                new Aeropuerto(){Codigo ="NAP"},
                new Aeropuerto(){Codigo ="NIC"},
                new Aeropuerto(){Codigo ="NLK"},
                new Aeropuerto(){Codigo ="OPO"},
                new Aeropuerto(){Codigo ="ORA"},
                new Aeropuerto(){Codigo ="ORK"},
                new Aeropuerto(){Codigo ="ORY"},
                new Aeropuerto(){Codigo ="OYA"},
                new Aeropuerto(){Codigo ="ORD"},
                new Aeropuerto(){Codigo ="PBR"},
                new Aeropuerto(){Codigo ="PDP"},
                new Aeropuerto(){Codigo ="PDL"},
                new Aeropuerto(){Codigo ="PHL"},
                new Aeropuerto(){Codigo ="PIX"},
                new Aeropuerto(){Codigo ="PJC"},
                new Aeropuerto(){Codigo ="PRA"},
                new Aeropuerto(){Codigo ="PRQ"},
                new Aeropuerto(){Codigo ="PSY"},
                new Aeropuerto(){Codigo ="PTY"},
                new Aeropuerto(){Codigo ="PUQ"},
                new Aeropuerto(){Codigo ="PXO"},
                new Aeropuerto(){Codigo ="QGY"},
                new Aeropuerto(){Codigo ="QRC"},
                new Aeropuerto(){Codigo ="QSA"},
                new Aeropuerto(){Codigo ="RAK"},
                new Aeropuerto(){Codigo ="RES"},
                new Aeropuerto(){Codigo ="REU"},
                new Aeropuerto(){Codigo ="RGA"},
                new Aeropuerto(){Codigo ="RHD"},
                new Aeropuerto(){Codigo ="RLO"},
                new Aeropuerto(){Codigo ="ROS"},
                new Aeropuerto(){Codigo ="RRG"},
                new Aeropuerto(){Codigo ="RSA"},
                new Aeropuerto(){Codigo ="RUH"},
                new Aeropuerto(){Codigo ="SAL"},
                new Aeropuerto(){Codigo ="SAP"},
                new Aeropuerto(){Codigo ="SBZ"},
                new Aeropuerto(){Codigo ="SCL"},
                new Aeropuerto(){Codigo ="SDE"},
                new Aeropuerto(){Codigo ="SFM"},
                new Aeropuerto(){Codigo ="SFN"},
                new Aeropuerto(){Codigo ="SIN​"},
                new Aeropuerto(){Codigo ="SJO"},
                new Aeropuerto(){Codigo ="SJZ"},
                new Aeropuerto(){Codigo ="SKG"},
                new Aeropuerto(){Codigo ="SLA"},
                new Aeropuerto(){Codigo ="SMA"},
                new Aeropuerto(){Codigo ="SNU"},
                new Aeropuerto(){Codigo ="SXB"},
                new Aeropuerto(){Codigo ="SYD"},
                new Aeropuerto(){Codigo ="TER"},
                new Aeropuerto(){Codigo ="TFN"},
                new Aeropuerto(){Codigo ="TFS"},
                new Aeropuerto(){Codigo ="TGD"},
                new Aeropuerto(){Codigo ="TGU"},
                new Aeropuerto(){Codigo ="THF"},
                new Aeropuerto(){Codigo ="TLS"},
                new Aeropuerto(){Codigo ="TLV"},
                new Aeropuerto(){Codigo ="TPE"},
                new Aeropuerto(){Codigo ="TRS"},
                new Aeropuerto(){Codigo ="TSE"},
                new Aeropuerto(){Codigo ="TTG"},
                new Aeropuerto(){Codigo ="TUR"},
                new Aeropuerto(){Codigo ="UIO"},
                new Aeropuerto(){Codigo ="USH"},
                new Aeropuerto(){Codigo ="UZU"},
                new Aeropuerto(){Codigo ="VCP"},
                new Aeropuerto(){Codigo ="VDC"},
                new Aeropuerto(){Codigo ="VIE"},
                new Aeropuerto(){Codigo ="VLC"},
                new Aeropuerto(){Codigo ="VLL"},
                new Aeropuerto(){Codigo ="VME"},
                new Aeropuerto(){Codigo ="VVI"},
                new Aeropuerto(){Codigo ="WLG"},
                new Aeropuerto(){Codigo ="XRY"},
                new Aeropuerto(){Codigo ="YFB"},
                new Aeropuerto(){Codigo ="YHU"},
                new Aeropuerto(){Codigo ="YHZ"},
                new Aeropuerto(){Codigo ="YOW"},
                new Aeropuerto(){Codigo ="YQB"},
                new Aeropuerto(){Codigo ="YRB"},
                new Aeropuerto(){Codigo ="YUL"},
                new Aeropuerto(){Codigo ="YVM"},
                new Aeropuerto(){Codigo ="YVR"},
                new Aeropuerto(){Codigo ="YWG"},
                new Aeropuerto(){Codigo ="YYY"},
                new Aeropuerto(){Codigo ="YYZ"},
                new Aeropuerto(){Codigo ="ZAG"},
                new Aeropuerto(){Codigo ="ZAZ"},
            };


            return picker;
        }












    }

}
