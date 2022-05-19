using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppControles.Views
{
    public class Navegacion2View : ContentPage
    {
        public Navegacion2View()
        {
            //DEBEMOS IR CREANDO LOS CONTROLES DE FORMA DINAMICA
            //TAL Y COMO HEMOS VISTO EN EL EJEMPLO ANTERIOR.
            StackLayout stack = new StackLayout();
            stack.BackgroundColor = Color.Yellow;
            Label header = new Label();
            header.Text = "Pagina navegacion 2";
            header.FontSize = 35;
            header.VerticalOptions = LayoutOptions.StartAndExpand;
            stack.Children.Add(header);
            this.Content = stack;
        }
    }
}