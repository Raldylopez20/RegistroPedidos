using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPedidos.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        public string Descripcion { get; set; }

        public double Costo { get; set; }

        public double Inventario { get; set; }

        [ForeignKey("ProductoId")]
        public virtual List<Productos> Detalle { get; set; } = new List<Productos>();
    }
}