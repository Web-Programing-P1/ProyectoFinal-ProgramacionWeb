using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class Concesionario
{
    public int IdConcesionario { get; set; }

    public string? NombreConcesionario { get; set; }

    public virtual ICollection<ServicioOficial> ServicioOficials { get; } = new List<ServicioOficial>();

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
