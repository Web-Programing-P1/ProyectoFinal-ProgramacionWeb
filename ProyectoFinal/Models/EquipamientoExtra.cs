using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class EquipamientoExtra
{
    public int IdEquipamientoExtra { get; set; }

    public int? IdModelo { get; set; }

    public string? NombreEquipamientoExtra { get; set; }

    public decimal? Precio { get; set; }

    public virtual Modelo? IdModeloNavigation { get; set; }

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra01Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra02Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra03Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra04Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra05Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra06Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra07Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra08Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra09Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra10Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra11Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra12Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra13Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra14Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra15Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra16Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra17Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra18Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra19Navigations { get; } = new List<VehiculoPersonalizado>();

    public virtual ICollection<VehiculoPersonalizado> VehiculoPersonalizadoExtra20Navigations { get; } = new List<VehiculoPersonalizado>();
}
