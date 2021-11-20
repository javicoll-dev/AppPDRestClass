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
    public partial class VistaActualizar : ContentPage
    {
        //Datos selectList;
        //public VistaActualizar(Datos selectList)
        public VistaActualizar(int codigo, string nombre, string apellido, int edad)
        {
            InitializeComponent();

            txtCodigo.Text = Convert.ToString(codigo);
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtCodigo.Text = Convert.ToString(edad);



        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Set("codigo", txtCodigo.Text);
                parametros.Set("nombre", txtNombre.Text);
                parametros.Set("apellido", txtApellido.Text);
                parametros.Set("edad", txtEdad.Text);
                DisplayAlert("Alerta", "Se actualizaron los datos correctamente", "OK");
                cliente.UploadValues("http://192.168.100.33/moviles/post.php", "PUT", parametros);
                
            }
            catch (Exception ex)
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