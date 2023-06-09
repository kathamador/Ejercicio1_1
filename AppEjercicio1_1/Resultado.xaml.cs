using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEjercicio1_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultado : ContentPage
    {
        public string Descripcion { get; set; }
        public float Resul { get; set; }
        public Resultado(string descripcion, float resultado)
        {
            Descripcion = descripcion;
            Resul = resultado;
            BindingContext = this;
            InitializeComponent();
        }
    }
}