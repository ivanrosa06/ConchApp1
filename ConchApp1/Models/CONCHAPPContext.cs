﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ConchApp1.Models
{
    public class CONCHAPPContext :DbContext
    {
        public CONCHAPPContext()

            :base("CONCHAPPDBContext")
        {
        }
        public DbSet<Parada> Paradas { get; set; }
        public DbSet<UsuariosTransportistas> UsuariosTransportistas { get; set; }
        public DbSet<UsuarioPasajero> UsuarioPasajeros { get; set; }
        

    }
}