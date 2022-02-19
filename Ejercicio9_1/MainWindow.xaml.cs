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

namespace Ejercicio9_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*  Crear una estructura para guardar
            los productos de una tienda. */

        Tienda t;

        public MainWindow()
        {
            InitializeComponent();
        }

        private struct Tienda
        {
            public int codigo;
            public string descripcion;
            public int costo;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            CodigoTextBox.Text = "";
            DescripcionTextBox.Text = "";
            CostoTextBox.Text = "";
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            t.codigo = int.Parse(CodigoTextBox.Text);
            t.descripcion = DescripcionTextBox.Text;
            t.costo = int.Parse(CostoTextBox.Text);
            
            MessageBox.Show("Se a guardado con exito.");
        }
    }
}
