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

namespace Ejercicio8_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*  Hacer un programa que le solicite al usuario dos 
            cadenas y luego las muestre en orden alfabético. */
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OrganizarButton_Click(object sender, RoutedEventArgs e)
        {
            if(string.Compare(PrimeraPalabraTextBox.Text, SegundaPalabraTextBox.Text) < 0)
                ResultadoTextBox.Text = $"{PrimeraPalabraTextBox.Text}\n{SegundaPalabraTextBox.Text}";
            else
                ResultadoTextBox.Text = $"{SegundaPalabraTextBox.Text}\n{PrimeraPalabraTextBox.Text}";
        }
    }
}
