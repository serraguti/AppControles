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
    public partial class PaginaEventos : ContentPage
    {
        bool IsActiveWindow;

        public PaginaEventos()
        {
            InitializeComponent();
            //SIEMPRE REALIZAR LAS ACCIONES DESPUES DE ESTE METODO
            this.botonAccion.Clicked += MostrarNombre;
            this.slider1.ValueChanged += Slider1_ValueChanged;
            this.stepper1.ValueChanged += Stepper1_ValueChanged;
        }

        private void Stepper1_ValueChanged(object sender
            , ValueChangedEventArgs e)
        {
            this.labelResultado.Text =
                "Valor Stepper: " + e.NewValue;
        }

        private void Slider1_ValueChanged(object sender
            , ValueChangedEventArgs e)
        {
            this.labelResultado.Text =
                "Valor del Slider: " + e.NewValue;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.IsActiveWindow = true;
            //INICIAMOS EL TIMER DEL DISPOSITIVO
            Device.StartTimer
                (TimeSpan.FromSeconds(0.1), IniciarProcesoTimer);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            this.IsActiveWindow = false;
        }

        //METODO PARA CAMBIAR LA BARRA DE PROGRESO EN UN TIEMPO
        //DETERMINADO
        bool IniciarProcesoTimer()
        {
            this.progressBar1.Progress += 0.01;
            return this.IsActiveWindow || 
                this.progressBar1.Progress == 1;
        }

        private void MostrarNombre(object sender, EventArgs e)
        {
            string nombre = this.cajaNombre.Text;
            this.labelResultado.Text = "Su nombre es " + nombre;
        }
    }
}