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
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if(txtUsuario.Text == "Maria" && txtContraseña.Password == "1234")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.framePrincipal.NavigationService.Navigate(new PageAdministrador());
            }
            else
            if((txtUsuario.Text == "Elsa") || (txtUsuario.Text == "Camilo") && txtContraseña.Password =="9876")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.framePrincipal.NavigationService.Navigate(new PageEmpleados());
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña inválidos");
            }
        }
    }
}
