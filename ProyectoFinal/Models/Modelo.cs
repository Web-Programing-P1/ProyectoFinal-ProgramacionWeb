using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class Modelo
{
    public int IdModelo { get; set; }

    public int? IdMarca { get; set; }

    public string NombreModelo { get; set; } = null!;

    public string Potencia { get; set; } = null!;

    public string Cilindrada { get; set; } = null!;

    public string Combustible { get; set; } = null!;

    public string? Pasajeros { get; set; }

    public string Traccion { get; set; } = null!;

    public decimal PrecioBase { get; set; }

    public string? ImgModelo { get; set; }

    public virtual ICollection<EquipamientoExtra> EquipamientoExtras { get; } = new List<EquipamientoExtra>();

    public virtual ICollection<EquipamientoSerie> EquipamientoSeries { get; } = new List<EquipamientoSerie>();

    public virtual Marca? IdMarcaNavigation { get; set; }

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizados { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculosStock> VehiculosStocks { get; } = new List<VehiculosStock>();

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
