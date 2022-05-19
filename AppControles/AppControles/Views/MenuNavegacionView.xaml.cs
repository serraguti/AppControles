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
    public partial class MenuNavegacionView : ContentPage
    {
        public MenuNavegacionView()
        {
            InitializeComponent();
            this.botonNavegacion1.Clicked += BotonNavegacion1_Clicked;
            this.botonNavegacion2.Clicked += BotonNavegacion2_Clicked;
        }

        private async void BotonNavegacion1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navegacion1View());
        }

        private async void BotonNavegacion2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Navegacion2View());
        }
    }
}