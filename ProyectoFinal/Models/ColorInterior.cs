using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class ColorInterior
{
    public int IdColorInterior { get; set; }

    public string? ColorInterior1 { get; set; }

    public decimal? PrecioColorInterior { get; set; }

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizados { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculosStock> VehiculosStocks { get; } = new List<VehiculosStock>();
}
