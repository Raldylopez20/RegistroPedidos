using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using RegistroPedidos.DAL;
using RegistroPedidos.Entidades;
using System.Text;


namespace RegistroPedidos.BLL
{
    public class ProductosBLL
    {
        public static List<Productos> GetProductos()
        {
            List<Productos> productos = new List<Productos>();
            Contexto contexto = new Contexto();

            try
            {
                productos = contexto.Productos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return productos;
        }
    }
}