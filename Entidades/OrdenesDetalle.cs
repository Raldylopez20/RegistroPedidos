using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPedidos.Entidades
{
    public class OrdenesDetalle
    {
        [Key]

        public int OrdenDetalle { get; set; }
        public int OrdenId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public int SuplidorId { get; set; }

        //public decimal Costo { get; set; }

         [ForeignKey("ProductoId")]
        public Productos productos { get; set; } = new Productos();

        

    }
}