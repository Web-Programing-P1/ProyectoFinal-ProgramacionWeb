using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class VehiculosStock
{
    public int IdVehiculoStock { get; set; }

    public int? IdMarca { get; set; }

    public int? IdModelo { get; set; }

    public string? Vin { get; set; }

    public int? ColorExterior { get; set; }

    public int? ColorInterior { get; set; }

    public string? Anio { get; set; }

    public string? DescripcionEquipamientoExtra { get; set; }

    public decimal? Precio { get; set; }

    public virtual ColorExterior? ColorExteriorNavigation { get; set; }

    public virtual ColorInterior? ColorInteriorNavigation { get; set; }

    public virtual Marca? IdMarcaNavigation { get; set; }

    public virtual Modelo? IdModeloNavigation { get; set; }

    public virtual ICollection<Venta> VentaPrecioVehiculoStockNavigations { get; } = new List<Venta>();

    public virtual ICollection<Venta> VentaVinVehiculoStockNavigations { get; } = new List<Venta>();
}
