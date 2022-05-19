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
    public partial class DynamicControlsView : ContentPage
    {
        public DynamicControlsView()
        {
            InitializeComponent();
            this.botonGenerar.Clicked += GenerarBotones;
        }

        private void GenerarBotones(object sender, EventArgs e)
        {
            int numeroBotones = int.Parse(this.cajaNumero.Text);
            for (int i = 1; i <= numeroBotones; i++)
            {
                //VERDES
                Button boton = new Button();
                boton.Text = "Botón " + i;
                boton.HorizontalOptions = 
                    LayoutOptions.FillAndExpand;
                this.contenedor.Children.Add(boton);
                boton.Clicked += BotonPulsado;
                //ROJOS
                Button boton1 = new Button();
                boton1.Text = "Botón " + i;
                boton1.HorizontalOptions =
                    LayoutOptions.FillAndExpand;
                this.containerHorizontal.Children.Add(boton1);
                boton1.Clicked += BotonPulsado;
            }
        }

        private void BotonPulsado(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.BackgroundColor = Color.White;
        }
    }
}