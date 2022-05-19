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
    public partial class PaginaModalView : ContentPage
    {
        public PaginaModalView()
        {
            InitializeComponent();
            this.botonCerrar.Clicked += async (sender, args) =>
            {
                await Navigation.PopModalAsync();
            };
        }
    }
}