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
using System.Windows.Shapes;
using RegistroPedidos.BLL;
using RegistroPedidos.Entidades;
using RegistroPedidos.DAL;

namespace RegistroPedidos.UI.Registro
{
    public partial class rPedidos : Window
    {
        private Ordenes ordenes = new Ordenes();
        public rPedidos()
        {
            InitializeComponent();
            this.DataContext = ordenes;

            //——————————————————————————[ VALORES DEL ComboBox Suplidores]——————————————————————————
            SuplidorIdComboBox.ItemsSource = SuplidoresBLL.GetSuplidores();
            SuplidorIdComboBox.SelectedValuePath = "SuplidorId";
            SuplidorIdComboBox.DisplayMemberPath = "Nombres";

            //——————————————————————————[ VALORES DEL ComboBox Productos]——————————————————————————
            ProductoIdComboBox.ItemsSource = ProductosBLL.GetProductos();
            ProductoIdComboBox.SelectedValuePath = "ProductoId";
            ProductoIdComboBox.DisplayMemberPath = "Descripcion";
        }
        //—————————————————————————————————————————————————————[ CARGAR ]—————————————————————————————————————————————————————
        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = ordenes;
        }
        //—————————————————————————————————————————————————————[ LIMPIAR ]—————————————————————————————————————————————————————
        private void Limpiar()
        {
            this.ordenes = new Ordenes();
            this.DataContext = ordenes;
        }
        //—————————————————————————————————————————————————————[ Validar ]—————————————————————————————————————————————————————
        private bool Validar()
        {
            bool Validado = true;

           /* if (SuplidorIdComboBox.Text.Length == 0)
            {
                Validado = false;
                MessageBox.Show("El campo Suplidor esta vacio,Por favor llenarlo y continuar", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
           if (ProductoIdComboBox.Text.Length == 0)
            {
                Validado = false;
                MessageBox.Show("El campo Producto Id esta vacio, Por favor llenarlo y continuar", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (CantidadTextBox.Text.Length == 0)
            {
                Validado = false;
                MessageBox.Show("El campo Cantidad  esta vacio, Por favor llenarlo y continuar", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }*/
            return Validado;

        }
        //—————————————————————————————————————————————————————[ BUSCAR ]—————————————————————————————————————————————————————
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Ordenes encontrado = OrdenesBLL.Buscar(ordenes.OrdenId);

            if (encontrado != null)
            {
                ordenes = encontrado;
                Cargar();
            }
            else
            {
                MessageBox.Show($"Este pedido no fue encontrado.\n\nAsegurese que existe o cree uno nuevo.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
                PedidoIdTextbox.Clear();
                PedidoIdTextbox.Focus();
            }
        }
        //—————————————————————————————————————————————————————[ AGREGAR FILA ]—————————————————————————————————————————————————————
       private void AgregarFilaButton_Click(object sender, RoutedEventArgs e)

        {
           if (SuplidorIdComboBox.Text == string.Empty)
            {
                MessageBox.Show($"El campo Suplidor Id esta vacio.\n\nSeleccione un Suplidor.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Warning);
                SuplidorIdComboBox.IsDropDownOpen = true;
                return;
            }
            Productos producto = (Productos)ProductoIdComboBox.SelectedItem;
            var filaDetalle = new OrdenesDetalle
            {
                OrdenId = this.ordenes.OrdenId,
                ProductoId = Convert.ToInt32(ProductoIdComboBox.SelectedValue.ToString()),
                productos = (Productos)ProductoIdComboBox.SelectedItem,
                Cantidad = Convert.ToInt32(CantidadTextBox.Text)
            };
              ordenes.Monto = producto.Costo * int.Parse(CantidadTextBox.Text);
            this.ordenes.Detalle.Add(filaDetalle);
            Cargar();

            ProductoIdComboBox.SelectedIndex = -1;
            CantidadTextBox.Clear();
            CantidadTextBox.Focus();
        }
        //—————————————————————————————————————————————————————[ REMOVER FILA ]—————————————————————————————————————————————————————
        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                var detalle = (OrdenesDetalle)DetalleDataGrid.SelectedItem;
                    
                ordenes.Monto = ordenes.Monto - (detalle.productos.Costo * (int)detalle.Cantidad);
                ordenes.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }
        //—————————————————————————————————————————————————————[ NUEVO ]—————————————————————————————————————————————————————
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        //—————————————————————————————————————————————————————[ GUARDAR ]—————————————————————————————————————————————————————
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                var paso = OrdenesBLL.Guardar(this.ordenes);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transaccion Errada", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);

                    
            }
        }
        //—————————————————————————————————————————————————————[ ELIMINAR ]—————————————————————————————————————————————————————
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (OrdenesBLL.Eliminar(Utilidades.ToInt(PedidoIdTextbox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}