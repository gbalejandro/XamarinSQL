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
	public partial class PaginaEmpleado : ContentPage
	{
        public Empleados Empleado;

        public PaginaEmpleado ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = this.Empleado;
        }

        void btnGuardar_Click(object sender, EventArgs a)
        {
            if (Empleado.ID == 0)
                BaseDatos.AgregarEmpleado(Empleado);
            else
                BaseDatos.ModificarEmpleado(Empleado);

            Navigation.PopAsync();
        }

        void btnEliminar_Click(object sender, EventArgs a)
        {
            if (Empleado.ID != 0)
            {
                BaseDatos.EliminarEmpleado(Empleado);
                Navigation.PopAsync();
            }
        }
    }
}