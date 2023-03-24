using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class Marca
{
    public int IdMarca { get; set; }

    public string NombreMarca { get; set; } = null!;

    public string? UrlLogoMarca { get; set; }

    public virtual ICollection<Modelo> Modelos { get; } = new List<Modelo>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizados { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculosStock> VehiculosStocks { get; } = new List<VehiculosStock>();

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
