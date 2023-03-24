using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class MetodoPago
{
    public int IdMetodoPago { get; set; }

    public string? MetodoPago1 { get; set; }

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
