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

namespace Ejercicio9_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*  Crear estructuras enlazadas para guardar
            la información de una mascota y su dueño. */

        Dueno d;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private struct Dueno
        {
            public string Nombre;
            public string Numero;
            public int Edad;
            public Mascota mascota;
            public struct Mascota
            {
                public string NombreM;
                public string Tipo;
                public int Edad;
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            NombreTextBox.Text = "";
            EdadTextBox.Text = "";
            NumeroTextBox.Text = "";
            NombreMascotaTextBox.Text = "";
            TipoMascotaTextBox.Text = "";
            EdadMascotaTextBox.Text = "";
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            d.Nombre = NombreTextBox.Text;
            d.Edad = Convert.ToInt16(EdadTextBox.Text);
            d.Numero = NumeroTextBox.Text;
            d.mascota.NombreM = NombreMascotaTextBox.Text;
            d.mascota.Tipo = TipoMascotaTextBox.Text;
            d.mascota.Edad = Convert.ToInt16(EdadMascotaTextBox.Text);

            MessageBox.Show("Se a guardado con exito.");
        }
    }
}
