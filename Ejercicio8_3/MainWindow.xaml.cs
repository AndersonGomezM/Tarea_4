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
using System.Threading;

namespace Ejercicio8_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*  Hacer un programa que muestre la hora del día en formato
            AM/FM seguida del año, el día y el mes actual. */
        public MainWindow()
        {
            InitializeComponent();
            if(DateTime.Now.Hour < 12)
                RelogTextBlock.Text = string.Format("{0:dd/MM/yyyy hh:mm:ss} AM", DateTime.Now);
            else
                RelogTextBlock.Text = string.Format("{0:dd/MM/yyyy hh:mm:ss} PM", DateTime.Now);
        }
    }
}
