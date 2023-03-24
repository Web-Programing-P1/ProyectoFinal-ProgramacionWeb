using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class ColorExterior
{
    public int IdColorExterior { get; set; }

    public string? ColorExterior1 { get; set; }

    public decimal? PrecioColorExterior { get; set; }

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizados { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculosStock> VehiculosStocks { get; } = new List<VehiculosStock>();
}
