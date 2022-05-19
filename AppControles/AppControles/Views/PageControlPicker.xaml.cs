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
    public partial class PageControlPicker : ContentPage
    {
        List<string> elementos;

        public PageControlPicker()
        {
            InitializeComponent();
            this.elementos = new List<string>
            {
                "Net Core", "Azure", "AWS", "Front-End", "Xamarin"
            };
            foreach (string dato in this.elementos)
            {
                this.pickerOpciones.Items.Add(dato);
            }
            //VOY A ESCRIBIR UN METODO DELEGADO CON LAMBDA
            this.pickerOpciones.SelectedIndexChanged += (sender, args) =>
            {
                if (this.pickerOpciones.SelectedIndex != -1)
                {
                    string dato = 
                    this.elementos[this.pickerOpciones.SelectedIndex];
                    this.labelSeleccionado.Text = dato;
                }
            };
        }
    }
}