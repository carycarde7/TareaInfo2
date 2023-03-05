using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaInfo.VIews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageInfo : ContentPage
    {
        public PageInfo()
        {
            InitializeComponent();
        }

        private async void btnmostrar_Clicked(object sender, EventArgs e)
        {
            var info = new Models.InfoClass
            {
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                edad = int.Parse(txtedad.Text),
                correo = txtcorreo.Text,


            };
            

            var page = new VIews.Resultados();
            page.BindingContext= info;
            await Navigation.PushAsync(page);

            

        }
    }
}