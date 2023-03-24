using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class ServicioOficialVendedore
{
    public int IdVendedor { get; set; }

    public int? IdServicioOficial { get; set; }

    public string? NombreVendedor { get; set; }

    public string? CedulaVendedor { get; set; }

    public string? Domicilio { get; set; }

    public virtual ServicioOficial? IdServicioOficialNavigation { get; set; }

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
