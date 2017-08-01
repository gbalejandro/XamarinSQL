using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSQL.Clases;

namespace XamarinSQL.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaListaEmpleados : ContentPage
	{
		public PaginaListaEmpleados ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lsvEmpleados.ItemsSource = BaseDatos.ObtenerEmpleados();
        }

        private void lsvEmpleados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                NavegarEmpleado(e.SelectedItem as Empleados);
        }

        void btnNuevo_Click(object sender, EventArgs a)
        {
            NavegarEmpleado(new Empleados());
        }

        void NavegarEmpleado(Empleados empleado)
        {
            PaginaEmpleado pagina = new PaginaEmpleado();
            pagina.Empleado = empleado;
            Navigation.PushAsync(pagina);
        }
    }
}