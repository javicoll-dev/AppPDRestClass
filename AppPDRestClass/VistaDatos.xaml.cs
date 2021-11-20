using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPDRestClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaDatos : ContentPage
    {
        private const string url = "http://192.168.100.33/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<AppPDRestClass.Datos> _post;
        public VistaDatos()
        {
            InitializeComponent();
        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(url);
            List<AppPDRestClass.Datos> posts = JsonConvert.DeserializeObject<List<AppPDRestClass.Datos>>(content);
            _post = new ObservableCollection<Datos>(posts);

            MyListView.ItemsSource = _post;
        }

        private void btnPost_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VistaInsertar());
        }

        private void btnPut_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VistaActualizar());
        }

        private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var content = await client.GetStringAsync(url);
            List<AppPDRestClass.Datos> posts = JsonConvert.DeserializeObject<List<AppPDRestClass.Datos>>(content);
            _post = new ObservableCollection<Datos>(posts);

            //Datos selectList = MyListView.SelectedItem as Datos;


            //Task task = Navigation.PushAsync(new VistaActualizar(selectList));
        }
    }
}