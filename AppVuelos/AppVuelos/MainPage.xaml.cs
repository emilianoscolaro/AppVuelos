using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppVuelos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
        }

        string pantallauno;
        char[] car;
        char[] cardos;

        string st = "VUELO    FECHA   AEROP.    HORARIO \n";

        public void Button_Clicked(object sender, EventArgs e)
        {
    //        pantallauno = Pantalla.Text;
            if (pantallauno[2] == ' ')
                pantallauno = pantallauno.Remove(2, 1);
            if (pantallauno[12] != ' ')
                pantallauno = pantallauno.Remove(12, 1);
            car = new char[pantallauno.Length];
            cardos = new char[pantallauno.Length];
            for (int i = 0; i < pantallauno.Length; i++)
            {
                car[i] = pantallauno[i];
            }

            st = st + car[5] + car[6] + car[7] + car[8] + car[9] + car[10] + "  " + car[13] + car[14] + car[15] + car[16] + car[17] + "   " + car[21] + car[22] +
                car[23] + car[24] + car[25] + car[26] + "   " + car[33] + car[34] + car[35] + car[36] + car[37] + car[38] + car[39] + car[40] +
                car[41] + "\n" + car[69] + car[70] + car[71] + car[72] + car[73] + car[74] + "  " + car[77] + car[78] + car[79] + car[80] + car[81] + "   " + car[85] + car[86] +
                car[87] + car[88] + car[89] + car[90] + "   " + car[97] + car[98] + car[99] + car[100] + car[101] + car[102] + car[103] + car[104] +
                car[105] + "\n" + car[133] + car[134] + car[135] + car[136] + car[137] + car[138] + "  " + car[141] + car[142] + car[143] + car[144] + car[145] + "   " + car[149] + car[150] +
                car[151] + car[152] + car[153] + car[154] + "   " + car[161] + car[162] + car[163] + car[164] + car[165] + car[166] + car[167] + car[168] +
                car[169] + "\n";

            

     //       PantallaDos.Text = st;

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
   //         Pantalla.Text = " ";
   //         PantallaDos.Text = "";
            st = "VUELO    FECHA   AEROP.    HORARIO \n";
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            OrdenadoePage nuevapagina = new OrdenadoePage();
            await Navigation.PushAsync(nuevapagina);
        }
    }
    
}
