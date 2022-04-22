using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inventarios
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ID_USUARIO.Text) && !string.IsNullOrEmpty(PASSWORD.Text))
            {
                var getApi = RestService.For<IUsuarioLogin>("https://sirvamonos.com/examen");
                var resultado = await getApi.GetUsuarioAsync(ID_USUARIO.Text, PASSWORD.Text);
            }
            else
            {
                _ = DisplayAlert("Ingresare datos", "Se requiere Usaurio y Contraseña", "Ok");

            }
        }
    }
}
