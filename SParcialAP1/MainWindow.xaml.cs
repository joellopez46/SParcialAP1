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
using SParcialAP1.UI.Registros;
using SParcialAP1.UI.Consulta;

namespace SParcialAP1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rRegistroMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Registros Reg = new Registros();
            Reg.Show();
        }

        private void cConsultaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cRegistro Con = new cRegistro();
            Con.Show();
        }

        
    }
}