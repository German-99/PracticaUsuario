using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaUsuarios
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Seleccionador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PanelConfiguracion.Children.Clear();
            var indexseleccionado = Seleccionador.SelectedIndex;
            if (indexseleccionado == 0)
            {
                PanelConfiguracion.Children.Add(new ControlAlumno());
            }
            else if (indexseleccionado == 1)
            {
                PanelConfiguracion.Children.Add(new ControlMaestro());
            }
         }

        private void btnGuardarUsuario_Click(object sender, RoutedEventArgs e)
        {
            var indexSeleccionado = Seleccionador.SelectedIndex;
            if (indexSeleccionado == 0)
            {
                var controlAlumno = (ControlAlumno)PanelConfiguracion.Children[0];
                if (controlAlumno.txtNombreA.Text == "")
                {
                    controlAlumno.lblNombreA.Foreground = Brushes.Red;
                }
                else
                {
                    controlAlumno.lblNombreA.Foreground = Brushes.Black;
                }
                if (controlAlumno.txtDireccionA.Text == "")
                {
                    controlAlumno.lblDireccionA.Foreground = Brushes.Red;
                }
                else
                {
                    controlAlumno.lblDireccionA.Foreground = Brushes.Black;
                }
                if (controlAlumno.cbCarreraA.Text == "")
                {
                    controlAlumno.lblCarreraA.Foreground = Brushes.Red;
                }
                else
                {
                    controlAlumno.lblCarreraA.Foreground = Brushes.Black;
                }
                if (controlAlumno.txtPreparatoriaP.Text == "")
                {
                    controlAlumno.lblPreparatoriaP.Foreground = Brushes.Red;
                }
                else
                {
                    controlAlumno.lblPreparatoriaP.Foreground = Brushes.Black;
                }
            }
            else if (indexSeleccionado == 1)
            {
                var controlMaestro = (ControlMaestro)PanelConfiguracion.Children[0];
                if (controlMaestro.txtNombreM.Text == "")
                {
                    controlMaestro.lblNombreM.Foreground = Brushes.Red;
                }
                else
                {
                    controlMaestro.lblNombreM.Foreground = Brushes.Black;
                }
                if (controlMaestro.txtTelefonoM.Text == "")
                {
                    controlMaestro.lblTelefonoM.Foreground = Brushes.Red;
                }
                else
                {
                    controlMaestro.lblTelefonoM.Foreground = Brushes.Black;
                }
                if (controlMaestro.txtCedulam.Text == "")
                {
                    controlMaestro.lblCedulaM.Foreground = Brushes.Red;
                }
                else
                {
                    controlMaestro.lblCedulaM.Foreground = Brushes.Black;
                }
                if (controlMaestro.txtCarreraM.Text == "")
                {
                    controlMaestro.lblCarreraM.Foreground = Brushes.Red;
                }
                else
                {
                    controlMaestro.lblCarreraM.Foreground = Brushes.Black;
                }
            }
        }
    }
}
