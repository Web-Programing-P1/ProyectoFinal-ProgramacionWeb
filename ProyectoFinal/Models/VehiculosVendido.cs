﻿using System;
using System.Collections.Generic;

namespace ProyectoFinal.Models;

public partial class VehiculosVendido
{
    public int IdVehiculoVendido { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? Vin { get; set; }

    public string? Cliente { get; set; }

    public string? Vendedor { get; set; }

    public decimal? Precio { get; set; }
}
