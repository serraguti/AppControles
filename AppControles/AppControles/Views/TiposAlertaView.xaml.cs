using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppControles.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TiposAlertaView : ContentPage
    {
        public TiposAlertaView()
        {
            InitializeComponent();
            this.botonSimple.Clicked += (sender, args) =>
            {
                DisplayAlert("Titulo", "Contenido del mensaje", "OK");
            };
            //EL RESTO DE ACCIONES ESPERAN UNA RESPUESTA DEL USUARIO
            //POR LO QUE SON ASINCRONAS
            this.botonOkCancel.Clicked += BotonOkCancel_Clicked;
            this.botonOpciones.Clicked += BotonOpciones_Clicked;
            this.botonModal.Clicked += BotonModal_Clicked;
        }

        private async void BotonOkCancel_Clicked(object sender, EventArgs e)
        {
            bool respuesta =
                await DisplayAlert("Preguntita..."
                , "Real Madrid Campeon de Champions???"
                , "Yes", "No");
            if (respuesta == true)
            {
                this.labelRespuesta.Text = "Tu si que sabes...";
            }
            else
            {
                this.labelRespuesta.Text = "Eres del Barsa...";
            }
        }

        private async void BotonOpciones_Clicked(object sender, EventArgs e)
        {
            string[] empresas = new []{ "Encamina", "Avanade", "Net Check", "Sogeti"
            , "DXC"};
            string respuesta =
                await DisplayActionSheet("Empresa??", "Cancelar"
                , "Destruction", empresas);
            this.labelRespuesta.Text = respuesta;
        }

        private async void BotonModal_Clicked(object sender, EventArgs e)
        {
            PaginaModalView view = new PaginaModalView();
            await Navigation.PushModalAsync(view);
        }
    }
}