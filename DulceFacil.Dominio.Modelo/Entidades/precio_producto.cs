﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class precio_producto
{
    public int id_precio_producto { get; set; }

    public decimal? precio { get; set; }

    public int? id_producto { get; set; }

    public virtual producto id_productoNavigation { get; set; }

    public virtual ICollection<precio_producto_historico> precio_producto_historico { get; set; } = new List<precio_producto_historico>();
}