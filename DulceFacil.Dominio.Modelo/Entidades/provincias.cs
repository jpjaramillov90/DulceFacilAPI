﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class provincias
{
    public int id_provincia { get; set; }

    public string provincia { get; set; }

    public virtual ICollection<direciones> direciones { get; set; } = new List<direciones>();
}