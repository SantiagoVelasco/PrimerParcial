using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial1_SantiagoVelasco
{
    /// <summary>
    /// Lógica de interacción para PageEmpleados.xaml
    /// </summary>
    public partial class PageEmpleados : Page
    {
        public PageEmpleados()
        {
            InitializeComponent();
        }

        int ventas = 0;
        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            string cliente = txtCliente.Text;
            string cedula = txtCedula.Text;
            txtVentas.Text = txtVentas.Text + cliente + "\n" + cedula +"\n" + txtContenido.Text + DateTime.Now.ToString() +"\n" + "\n";
            txtGanancias.Text = ventas.ToString();
            txtContenido.Text = "";
        }

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            string pan = cboPanes.Text;
            string cantidad = txtCantidad.Text;
            txtContenido.Text = txtContenido.Text + cantidad + " " + pan;

            int cant = int.Parse(txtCantidad.Text);
            if (cboPanes.SelectedIndex == 0)
            {
                int precio = cant * 1000;
                ventas += precio;
                txtContenido.Text = txtContenido.Text + "\n" + "Precio: " + precio + "\n";
            }
            else
            {
                if (cboPanes.SelectedIndex == 1)
                {
                    int precio = cant * 500;
                    ventas += precio;
                    txtContenido.Text = txtContenido.Text + "\n" + "Precio: " + precio + "\n";
                }
                else
                {
                    int precio = cant * 2000;
                    ventas += precio;
                    txtContenido.Text = txtContenido.Text + "\n" + "Precio: " + precio + "\n";
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtContenido.Text = "";
        }
    }
}
