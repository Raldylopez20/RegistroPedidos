using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPedidos.Entidades
{
    public class Suplidores
    {
        [Key]

        public int SuplidorId { get; set; }

        public string Nombres { get; set; }

        [ForeignKey("SuplidorId")]
        public virtual List<Productos> Detalle { get; set; } = new List<Productos>();

    }
}