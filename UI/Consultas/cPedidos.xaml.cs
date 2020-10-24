using RegistroPedidos.BLL;
using RegistroPedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Windows;


namespace RegistroPedidos.UI.Consultas
{
    public partial class cPedidos : Window
    {
        public cPedidos()
        {
            InitializeComponent();
        }

         private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            List<Ordenes> listado = new List<Ordenes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 1:
                        listado = OrdenesBLL.GetList(p => p.OrdenId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                }
            }
            else
            {
                listado = OrdenesBLL.GetList(c => true);
            }
            if (DesdeDatePicker.SelectedDate != null)
                listado = (List<Ordenes>)OrdenesBLL.GetList(p => p.Fecha.Date >= DesdeDatePicker.SelectedDate);
            
            if (HastaDatePicker.SelectedDate != null)
                listado = (List<Ordenes>)OrdenesBLL.GetList(p => p.Fecha.Date <= HastaDatePicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
}

}