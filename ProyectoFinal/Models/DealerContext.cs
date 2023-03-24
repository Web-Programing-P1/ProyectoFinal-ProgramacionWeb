using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.Models;

public partial class DealerContext : DbContext
{
    public DealerContext()
    {
    }

    public DealerContext(DbContextOptions<DealerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ColorExterior> ColorExteriors { get; set; }

    public virtual DbSet<ColorInterior> ColorInteriors { get; set; }

    public virtual DbSet<Concesionario> Concesionarios { get; set; }

    public virtual DbSet<EquipamientoExtra> EquipamientoExtras { get; set; }

    public virtual DbSet<EquipamientoSerie> EquipamientoSeries { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<ServicioOficial> ServicioOficials { get; set; }

    public virtual DbSet<ServicioOficialCliente> ServicioOficialClientes { get; set; }

    public virtual DbSet<ServicioOficialVendedore> ServicioOficialVendedores { get; set; }

    public virtual DbSet<VehiculoPersonalizado> VehiculoPersonalizados { get; set; }

    public virtual DbSet<VehiculosStock> VehiculosStocks { get; set; }

    public virtual DbSet<VehiculosVendido> VehiculosVendidos { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-TQBGB6A9\\SQLEXPRESS;Database=DEALER;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ColorExterior>(entity =>
        {
            entity.HasKey(e => e.IdColorExterior).HasName("PK__color_ex__A6FF2A21E8C12A45");

            entity.ToTable("color_exterior");

            entity.Property(e => e.IdColorExterior).HasColumnName("id_color_exterior");
            entity.Property(e => e.ColorExterior1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("color_exterior");
            entity.Property(e => e.PrecioColorExterior)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_color_exterior");
        });

        modelBuilder.Entity<ColorInterior>(entity =>
        {
            entity.HasKey(e => e.IdColorInterior).HasName("PK__color_in__9E309F1B6247274A");

            entity.ToTable("color_interior");

            entity.Property(e => e.IdColorInterior).HasColumnName("id_color_interior");
            entity.Property(e => e.ColorInterior1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("color_interior");
            entity.Property(e => e.PrecioColorInterior)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_color_interior");
        });

        modelBuilder.Entity<Concesionario>(entity =>
        {
            entity.HasKey(e => e.IdConcesionario).HasName("PK__concesio__FE95AA27B9B6B7D5");

            entity.ToTable("concesionario");

            entity.Property(e => e.IdConcesionario).HasColumnName("id_concesionario");
            entity.Property(e => e.NombreConcesionario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_concesionario");
        });

        modelBuilder.Entity<EquipamientoExtra>(entity =>
        {
            entity.HasKey(e => e.IdEquipamientoExtra).HasName("PK__equipami__E517FE91AB93DC50");

            entity.ToTable("equipamiento_extra");

            entity.Property(e => e.IdEquipamientoExtra).HasColumnName("id_equipamiento_extra");
            entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
            entity.Property(e => e.NombreEquipamientoExtra)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre_equipamiento_extra");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.EquipamientoExtras)
                .HasForeignKey(d => d.IdModelo)
                .HasConstraintName("fk_equipamientoExtra_modelo");
        });

        modelBuilder.Entity<EquipamientoSerie>(entity =>
        {
            entity.HasKey(e => e.IdEquipamientoSerie).HasName("PK__equipami__FA575F329DF9D6C0");

            entity.ToTable("equipamiento_serie");

            entity.Property(e => e.IdEquipamientoSerie).HasColumnName("id_equipamiento_serie");
            entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
            entity.Property(e => e.NombreEquipamientoExtra)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre_equipamiento_extra");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.EquipamientoSeries)
                .HasForeignKey(d => d.IdModelo)
                .HasConstraintName("fk_equipamientoSerie_modelo");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.IdMarca).HasName("PK__marca__7E43E99E30E1AB93");

            entity.ToTable("marca");

            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.NombreMarca)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_marca");
            entity.Property(e => e.UrlLogoMarca)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("url_logo_marca");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.IdMetodoPago).HasName("PK__metodo_p__85BE0EBC39978E15");

            entity.ToTable("metodo_pago");

            entity.Property(e => e.IdMetodoPago).HasColumnName("id_metodo_pago");
            entity.Property(e => e.MetodoPago1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("metodo_pago");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo).HasName("PK__modelo__B3BFCFF15FED3255");

            entity.ToTable("modelo");

            entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
            entity.Property(e => e.Cilindrada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cilindrada");
            entity.Property(e => e.Combustible)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("combustible");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.ImgModelo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("img_modelo");
            entity.Property(e => e.NombreModelo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre_modelo");
            entity.Property(e => e.Pasajeros)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pasajeros");
            entity.Property(e => e.Potencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("potencia");
            entity.Property(e => e.PrecioBase)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("precio_base");
            entity.Property(e => e.Traccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("traccion");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Modelos)
                .HasForeignKey(d => d.IdMarca)
                .HasConstraintName("fk_modelo_to_marca");
        });

        modelBuilder.Entity<ServicioOficial>(entity =>
        {
            entity.HasKey(e => e.IdServicioOficial).HasName("PK__servicio__50B63F825B6A37CB");

            entity.ToTable("servicio_oficial");

            entity.Property(e => e.IdServicioOficial).HasColumnName("id_servicio_oficial");
            entity.Property(e => e.DomicilioServicioOficial)
                .HasColumnType("text")
                .HasColumnName("domicilio_servicio_oficial");
            entity.Property(e => e.IdConcesionario).HasColumnName("id_concesionario");
            entity.Property(e => e.NombreServicioOficial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_servicio_oficial");
            entity.Property(e => e.RncServicioOficial)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("rnc_servicio_oficial");

            entity.HasOne(d => d.IdConcesionarioNavigation).WithMany(p => p.ServicioOficials)
                .HasForeignKey(d => d.IdConcesionario)
                .HasConstraintName("fk_servicioOficial_concesionario");
        });

        modelBuilder.Entity<ServicioOficialCliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__servicio__677F38F539E1E2E7");

            entity.ToTable("servicio_oficial_clientes");

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.CedulaCliente)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("cedula_cliente");
            entity.Property(e => e.IdServicioOficial).HasColumnName("id_servicio_oficial");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_cliente");
            entity.Property(e => e.TelefonoCliente)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("telefono_cliente");
        });

        modelBuilder.Entity<ServicioOficialVendedore>(entity =>
        {
            entity.HasKey(e => e.IdVendedor).HasName("PK__servicio__009303080B2C6001");

            entity.ToTable("servicio_oficial_vendedores");

            entity.Property(e => e.IdVendedor).HasColumnName("id_vendedor");
            entity.Property(e => e.CedulaVendedor)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("cedula_vendedor");
            entity.Property(e => e.Domicilio)
                .HasColumnType("text")
                .HasColumnName("domicilio");
            entity.Property(e => e.IdServicioOficial).HasColumnName("id_servicio_oficial");
            entity.Property(e => e.NombreVendedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_vendedor");

            entity.HasOne(d => d.IdServicioOficialNavigation).WithMany(p => p.ServicioOficialVendedores)
                .HasForeignKey(d => d.IdServicioOficial)
                .HasConstraintName("fk_servicioOficial_vendedores");
        });

        modelBuilder.Entity<VehiculoPersonalizado>(entity =>
        {
            entity.HasKey(e => e.IdConstruccionVehiculo).HasName("PK__vehiculo__712ECA30AF1923E4");

            entity.ToTable("vehiculo_personalizado");

            entity.Property(e => e.IdConstruccionVehiculo).HasColumnName("id_construccion_vehiculo");
            entity.Property(e => e.ColorExterior).HasColumnName("color_exterior");
            entity.Property(e => e.ColorInterior).HasColumnName("color_interior");
            entity.Property(e => e.Extra01).HasColumnName("extra_01");
            entity.Property(e => e.Extra02).HasColumnName("extra_02");
            entity.Property(e => e.Extra03).HasColumnName("extra_03");
            entity.Property(e => e.Extra04).HasColumnName("extra_04");
            entity.Property(e => e.Extra05).HasColumnName("extra_05");
            entity.Property(e => e.Extra06).HasColumnName("extra_06");
            entity.Property(e => e.Extra07).HasColumnName("extra_07");
            entity.Property(e => e.Extra08).HasColumnName("extra_08");
            entity.Property(e => e.Extra09).HasColumnName("extra_09");
            entity.Property(e => e.Extra10).HasColumnName("extra_10");
            entity.Property(e => e.Extra11).HasColumnName("extra_11");
            entity.Property(e => e.Extra12).HasColumnName("extra_12");
            entity.Property(e => e.Extra13).HasColumnName("extra_13");
            entity.Property(e => e.Extra14).HasColumnName("extra_14");
            entity.Property(e => e.Extra15).HasColumnName("extra_15");
            entity.Property(e => e.Extra16).HasColumnName("extra_16");
            entity.Property(e => e.Extra17).HasColumnName("extra_17");
            entity.Property(e => e.Extra18).HasColumnName("extra_18");
            entity.Property(e => e.Extra19).HasColumnName("extra_19");
            entity.Property(e => e.Extra20).HasColumnName("extra_20");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("VIN");

            entity.HasOne(d => d.ColorExteriorNavigation).WithMany(p => p.VehiculoPersonalizados)
                .HasForeignKey(d => d.ColorExterior)
                .HasConstraintName("fk_construct_color_exterior");

            entity.HasOne(d => d.ColorInteriorNavigation).WithMany(p => p.VehiculoPersonalizados)
                .HasForeignKey(d => d.ColorInterior)
                .HasConstraintName("fk_construct_color_interior");

            entity.HasOne(d => d.Extra01Navigation).WithMany(p => p.VehiculoPersonalizadoExtra01Navigations)
                .HasForeignKey(d => d.Extra01)
                .HasConstraintName("fk_construct_extra01");

            entity.HasOne(d => d.Extra02Navigation).WithMany(p => p.VehiculoPersonalizadoExtra02Navigations)
                .HasForeignKey(d => d.Extra02)
                .HasConstraintName("fk_construct_extra02");

            entity.HasOne(d => d.Extra03Navigation).WithMany(p => p.VehiculoPersonalizadoExtra03Navigations)
                .HasForeignKey(d => d.Extra03)
                .HasConstraintName("fk_construct_extra03");

            entity.HasOne(d => d.Extra04Navigation).WithMany(p => p.VehiculoPersonalizadoExtra04Navigations)
                .HasForeignKey(d => d.Extra04)
                .HasConstraintName("fk_construct_extra04");

            entity.HasOne(d => d.Extra05Navigation).WithMany(p => p.VehiculoPersonalizadoExtra05Navigations)
                .HasForeignKey(d => d.Extra05)
                .HasConstraintName("fk_construct_extra05");

            entity.HasOne(d => d.Extra06Navigation).WithMany(p => p.VehiculoPersonalizadoExtra06Navigations)
                .HasForeignKey(d => d.Extra06)
                .HasConstraintName("fk_construct_extra06");

            entity.HasOne(d => d.Extra07Navigation).WithMany(p => p.VehiculoPersonalizadoExtra07Navigations)
                .HasForeignKey(d => d.Extra07)
                .HasConstraintName("fk_construct_extra07");

            entity.HasOne(d => d.Extra08Navigation).WithMany(p => p.VehiculoPersonalizadoExtra08Navigations)
                .HasForeignKey(d => d.Extra08)
                .HasConstraintName("fk_construct_extra08");

            entity.HasOne(d => d.Extra09Navigation).WithMany(p => p.VehiculoPersonalizadoExtra09Navigations)
                .HasForeignKey(d => d.Extra09)
                .HasConstraintName("fk_construct_extra09");

            entity.HasOne(d => d.Extra10Navigation).WithMany(p => p.VehiculoPersonalizadoExtra10Navigations)
                .HasForeignKey(d => d.Extra10)
                .HasConstraintName("fk_construct_extra10");

            entity.HasOne(d => d.Extra11Navigation).WithMany(p => p.VehiculoPersonalizadoExtra11Navigations)
                .HasForeignKey(d => d.Extra11)
                .HasConstraintName("fk_construct_extra11");

            entity.HasOne(d => d.Extra12Navigation).WithMany(p => p.VehiculoPersonalizadoExtra12Navigations)
                .HasForeignKey(d => d.Extra12)
                .HasConstraintName("fk_construct_extra12");

            entity.HasOne(d => d.Extra13Navigation).WithMany(p => p.VehiculoPersonalizadoExtra13Navigations)
                .HasForeignKey(d => d.Extra13)
                .HasConstraintName("fk_construct_extra13");

            entity.HasOne(d => d.Extra14Navigation).WithMany(p => p.VehiculoPersonalizadoExtra14Navigations)
                .HasForeignKey(d => d.Extra14)
                .HasConstraintName("fk_construct_extra14");

            entity.HasOne(d => d.Extra15Navigation).WithMany(p => p.VehiculoPersonalizadoExtra15Navigations)
                .HasForeignKey(d => d.Extra15)
                .HasConstraintName("fk_construct_extra15");

            entity.HasOne(d => d.Extra16Navigation).WithMany(p => p.VehiculoPersonalizadoExtra16Navigations)
                .HasForeignKey(d => d.Extra16)
                .HasConstraintName("fk_construct_extra16");

            entity.HasOne(d => d.Extra17Navigation).WithMany(p => p.VehiculoPersonalizadoExtra17Navigations)
                .HasForeignKey(d => d.Extra17)
                .HasConstraintName("fk_construct_extra17");

            entity.HasOne(d => d.Extra18Navigation).WithMany(p => p.VehiculoPersonalizadoExtra18Navigations)
                .HasForeignKey(d => d.Extra18)
                .HasConstraintName("fk_construct_extra18");

            entity.HasOne(d => d.Extra19Navigation).WithMany(p => p.VehiculoPersonalizadoExtra19Navigations)
                .HasForeignKey(d => d.Extra19)
                .HasConstraintName("fk_construct_extra19");

            entity.HasOne(d => d.Extra20Navigation).WithMany(p => p.VehiculoPersonalizadoExtra20Navigations)
                .HasForeignKey(d => d.Extra20)
                .HasConstraintName("fk_construct_extra20");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.VehiculoPersonalizados)
                .HasForeignKey(d => d.IdMarca)
                .HasConstraintName("fk_constructVehiculo_marca");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.VehiculoPersonalizados)
                .HasForeignKey(d => d.IdModelo)
                .HasConstraintName("fk_constructVehiculo_modelo");
        });

        modelBuilder.Entity<VehiculosStock>(entity =>
        {
            entity.HasKey(e => e.IdVehiculoStock).HasName("PK__vehiculo__2C97B5732EFD269B");

            entity.ToTable("vehiculos_stock");

            entity.Property(e => e.IdVehiculoStock).HasColumnName("id_vehiculo_stock");
            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("anio");
            entity.Property(e => e.ColorExterior).HasColumnName("color_exterior");
            entity.Property(e => e.ColorInterior).HasColumnName("color_interior");
            entity.Property(e => e.DescripcionEquipamientoExtra)
                .HasColumnType("text")
                .HasColumnName("descripcion_equipamiento_extra");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("VIN");

            entity.HasOne(d => d.ColorExteriorNavigation).WithMany(p => p.VehiculosStocks)
                .HasForeignKey(d => d.ColorExterior)
                .HasConstraintName("fk_vehiculoStock_color_exterior");

            entity.HasOne(d => d.ColorInteriorNavigation).WithMany(p => p.VehiculosStocks)
                .HasForeignKey(d => d.ColorInterior)
                .HasConstraintName("fk_vehiculoStock_color_interior");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.VehiculosStocks)
                .HasForeignKey(d => d.IdMarca)
                .HasConstraintName("fk_vehiculoStock_marca");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.VehiculosStocks)
                .HasForeignKey(d => d.IdModelo)
                .HasConstraintName("fk_vehiculoStock_modelo");
        });

        modelBuilder.Entity<VehiculosVendido>(entity =>
        {
            entity.HasKey(e => e.IdVehiculoVendido).HasName("PK__vehiculo__EBE1BF2D498E0CF2");

            entity.ToTable("vehiculos_vendidos");

            entity.Property(e => e.IdVehiculoVendido).HasColumnName("id_vehiculo_vendido");
            entity.Property(e => e.Cliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cliente");
            entity.Property(e => e.Marca)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Modelo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vendedor");
            entity.Property(e => e.Vin)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("VIN");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__ventas__459533BF7A22FFDF");

            entity.ToTable("ventas");

            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaEntrega)
                .HasColumnType("date")
                .HasColumnName("fecha_entrega");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdConcesionario).HasColumnName("id_concesionario");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.IdModelo).HasColumnName("id_modelo");
            entity.Property(e => e.IdServicioOficial).HasColumnName("id_servicio_oficial");
            entity.Property(e => e.IdVendedor).HasColumnName("id_vendedor");
            entity.Property(e => e.MetodoPago).HasColumnName("metodo_pago");
            entity.Property(e => e.PrecioVehiculoPersonalizado).HasColumnName("precio_vehiculo_personalizado");
            entity.Property(e => e.PrecioVehiculoStock).HasColumnName("precio_vehiculo_stock");
            entity.Property(e => e.Registro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("registro");
            entity.Property(e => e.VinVehiculoPersonalizado).HasColumnName("VIN_vehiculo_personalizado");
            entity.Property(e => e.VinVehiculoStock).HasColumnName("VIN_vehiculo_stock");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("fk_venta_cliente");

            entity.HasOne(d => d.IdConcesionarioNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdConcesionario)
                .HasConstraintName("fk_venta_concesionario");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdMarca)
                .HasConstraintName("fk_venta_VehiculoMarca");

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdModelo)
                .HasConstraintName("fk_venta_VehiculoModelo");

            entity.HasOne(d => d.IdServicioOficialNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdServicioOficial)
                .HasConstraintName("fk_venta_servicio_oficial");

            entity.HasOne(d => d.IdVendedorNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdVendedor)
                .HasConstraintName("fk_venta_vendedor");

            entity.HasOne(d => d.MetodoPagoNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.MetodoPago)
                .HasConstraintName("fk_venta_metodoPago");

            entity.HasOne(d => d.PrecioVehiculoPersonalizadoNavigation).WithMany(p => p.VentaPrecioVehiculoPersonalizadoNavigations)
                .HasForeignKey(d => d.PrecioVehiculoPersonalizado)
                .HasConstraintName("fk_venta_precioPersonalizado");

            entity.HasOne(d => d.PrecioVehiculoStockNavigation).WithMany(p => p.VentaPrecioVehiculoStockNavigations)
                .HasForeignKey(d => d.PrecioVehiculoStock)
                .HasConstraintName("fk_venta_precioStock");

            entity.HasOne(d => d.VinVehiculoPersonalizadoNavigation).WithMany(p => p.VentaVinVehiculoPersonalizadoNavigations)
                .HasForeignKey(d => d.VinVehiculoPersonalizado)
                .HasConstraintName("fk_venta_VINpersonalizado");

            entity.HasOne(d => d.VinVehiculoStockNavigation).WithMany(p => p.VentaVinVehiculoStockNavigations)
                .HasForeignKey(d => d.VinVehiculoStock)
                .HasConstraintName("fk_venta_VINstock");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
