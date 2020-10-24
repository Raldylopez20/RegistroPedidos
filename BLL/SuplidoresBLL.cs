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
    public class SuplidoresBLL
    {
        public static List<Suplidores> GetSuplidores()
        {
            List<Suplidores> suplidores = new List<Suplidores>();
            Contexto contexto = new Contexto();

            try
            {
                suplidores = contexto.Suplidores.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return suplidores;
        }
    }
}