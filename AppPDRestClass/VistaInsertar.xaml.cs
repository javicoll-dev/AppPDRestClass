using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPDRestClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaInsertar : ContentPage
    {
        public VistaInsertar()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);
                DisplayAlert("Alerta", "Se insertaron los datos correctamente", "OK");
                cliente.UploadValues("http://192.168.100.33/moviles/post.php", "POST", parametros);
            }
            catch(Exception ex) 
            {
                DisplayAlert("Alerta", ex.Message, "OK");
            }
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VistaDatos());
        }
    }
}