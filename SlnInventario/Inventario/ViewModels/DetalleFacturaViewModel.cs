using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventario.ViewModels
{
    public class DetalleFacturaViewModel
    {        
        public DetalleFactura detalleFactura { get; set; }
        public IEnumerable<DetalleFactura> detallesFacturas { get; set; }
    }
}