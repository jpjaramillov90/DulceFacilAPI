﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class tipo_cliente
{
    public int id_tipo_cliente { get; set; }

    public string tipo_cliente1 { get; set; }

    public virtual ICollection<cliente> cliente { get; set; } = new List<cliente>();
}