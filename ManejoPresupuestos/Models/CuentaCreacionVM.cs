using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ManejoPresupuestos.Models
{
    public class CuentaCreacionVM: Cuenta
    {
      public IEnumerable<SelectListItem> TiposCuentas { get; set; }        
    }
}
