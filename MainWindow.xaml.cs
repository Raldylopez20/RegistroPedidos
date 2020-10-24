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
using RegistroPedidos.UI.Consultas;
using RegistroPedidos.UI.Registro;
using RegistroPedidos.BLL;


namespace RegistroPedidos
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rPedidosButton_Click(object sender, RoutedEventArgs e)
        {
            rPedidos rPedidos = new rPedidos();
            rPedidos.Show();
        }

        private void cPedidosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cPedidos cPedidos = new cPedidos();
            cPedidos.Show();
        }
    }
}