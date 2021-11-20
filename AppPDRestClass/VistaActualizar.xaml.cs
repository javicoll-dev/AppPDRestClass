using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPDRestClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaActualizar : ContentPage
    {
        //Datos selectList;
        //public VistaActualizar(Datos selectList)
        public VistaActualizar()
        {
            InitializeComponent();
            


        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VistaDatos());
        }
    }
}