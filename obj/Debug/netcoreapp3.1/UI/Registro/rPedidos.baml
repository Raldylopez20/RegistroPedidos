   M S B A M L   `   `   `  ����J  FRegistroPedidos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:RegistroPedidos.UI.RegistroRegistroPedidos.UI.Registro  5   	   *    $RegistroPedidos.UI.Registro.rPedidos   5   	   e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:RegistroPedidos.UI.Registro     5   	     � Title$  REGISTRO DE PEDIDOS��5   	   $	��510��6%   $	��640��62    � WindowStartupLocation$ CenterScreen=�6>   .��5
      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10q�6,   .+�5      �� $��	Pedido Id��6   $
��Bold"�6(   $��16(�6:   �� 5      $ 
Horizontal=�6   $��35��62   .+�5      �� -   5         ��Name$ PedidoIdTextbox��5      $	��230��6L   $��18(�6X   $
��Bold"�6f   $��Center=�6x   ��63   �� *	OrdenId+6x   �� 5      -   5         ��Name$ BuscarButton��5      $��50,0,0,0q�6/   $	��120��6A   .��5      �� $ 
Horizontal=�6!   .+�5      �� $��30��6    $��/imagenes/buscar.png��6,   �� 5      $��Buscar��6    $��17(�61   $
��Bold"�6?   5      5      5      �� 5      -   5         ��Name$ 
FechaLabel��5      $��Fecha��6(   $
��Bold"�68   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ FechaDatePicker��5      $��30��6Q   $��Center=�6]      SelectedDate 62   �� *Fecha+6]   �� 5#      -   5        $ 
SuplidorId��5#      $��
SuplidorId��6(   $
��Bold"�6=   �� 5$      -   5         ��Name$ SuplidorIdComboBox��5$      $	��100��6X   $
��Left=�6d   $��25��6   	 �� SelectedValue	 63   �� *
SuplidorId+6   �� 5)      $ Vertical=�6   .+�5*      �� $��0,10,0,0q�6   .��5+      �� .+�5,      �� $ 
Horizontal=�6%   $��0,10,0,0q�6>   .+�5-      �� $��
ProductoId��6$   �� 5.      -   5        $ ProductoIdComboBox��5.   '   $	��100��6C   $��0,0,30,0q�6O   �� 5/      $��Cantidad��6$   �� 50      -   5        $ CantidadTextBox��50   &   $	��100��6?   51      �� 56      $ 
Horizontal=�6%   $��0,10,0,0q�6>   $��Right=�6P   .+�5;      �� -	   5        $ AgregarFilaButton��5;   %   .��5<   "   �� $ 
Horizontal=�6-   .+�5=   &   �� $��/imagenes/Mas.png��6,   $��25��6G   �� 5>   &   $��Agregar fila��6,   5?   #   5@      �� 5E      -
   5        $ RemoverFilaButton��5E   %   $��20,0,0,0q�6@   .��5F   "   �� $ 
Horizontal=�6-   .+�5G   &   �� $��/imagenes/Menos.png��6,   $��25��6I   �� 5H   &   $��Eliminar fila��6,   5I   #   5J      5K      &   System.Windows.Controls.DataGrid  5Q      -   5        
  Name$
 DetalleDataGrid��5Q   #   $��80��6\      AutoGenerateColumns$ False��6h   $��0,10,0,0q�6�   ��6<   �� *	Detalle+   Columns 5R      0  *System.Windows.Controls.DataGridTextColumn  5S   "   ,  &System.Windows.Controls.DataGridColumn   Header$ 
ProductoId��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *
ProductoId+  5T   "   $ Descripcion��65    6J   �� *productos.Descripcion+  5U   "   $ Cantidad��65    6G   �� *
Cantidad+  5V   "   $ Costo��65    6D   �� *productos.Costo+  5W   "   $ 
Inventario��65    6I   �� *productos.Inventario+5Y      5[      5\      �� 5`      $��Monto��6   $��
340,15,0,0q�6(   $
��15px(�6<   $��SimSun-ExtB)�6L   �� 5a      -   5        $ MontoTextBox��5a      $��25��6H   $��60��6T    �� 
IsReadOnly$
 True��6_   $��230,-30,0,0q�6q   ��60   �� *Monto+6q   5d      �� 5j      $ 
Horizontal=�6   $��35��62   $��0,5,0,0q�6>   $��Center=�6O   .+�5k      �� -   5        $ NuevoButton��5k      $	��120��6H   .��5l      �� $ 
Horizontal=�6!   .+�5m      �� $��25��6    $��/imagenes/nuevo.png��6,   �� 5n      $��Nuevo��6    $��17(�60   $
��Bold"�6>   5o      5p      �� 5u      -   5        $ GuardarButton��5u      $	��120��6L   $��20,0,0,0q�6X   .��5v      �� $ 
Horizontal=�6!   .+�5w      �� $��30��6    $��/imagenes/guardar.png��6,   �� 5x      $��Guardar��6    $��17(�62   $
��Bold"�6@   5y      5z      �� 5      -   5        $ EliminarButton��5      $	��120��6N   $��20,0,0,0q�6Z   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $��30��6    $��/imagenes/Eliminar.1.png��6,   �� 5�      $��Eliminar��6    $��17(�63   $
��Bold"�6A   5�      5�      5�      5�      5�      5�      