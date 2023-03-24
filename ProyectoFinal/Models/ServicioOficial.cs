using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class ServicioOficial
{
    public int IdServicioOficial { get; set; }

    public int? IdConcesionario { get; set; }

    public string? NombreServicioOficial { get; set; }

    public string? DomicilioServicioOficial { get; set; }

    public string? RncServicioOficial { get; set; }

    public virtual Concesionario? IdConcesionarioNavigation { get; set; }

    public virtual ICollection<ServicioOficialVendedore> ServicioOficialVendedores { get; } = new List<ServicioOficialVendedore>();

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
