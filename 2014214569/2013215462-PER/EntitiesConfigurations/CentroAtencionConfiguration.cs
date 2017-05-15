﻿using _2014214569_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214569_PER.EntitiesConfigurations
{
    public class CentroAtencionConfiguration : EntityTypeConfiguration<CentroAtencion>
    {
        public CentroAtencionConfiguration()
        {
            ToTable("CentroAtencion");
            HasKey(a => a.CentroAtencionID);

            HasRequired(a => a.Direccion)
                .WithRequiredPrincipal(a => a.CentroAtencion);
             
        }
    }
}
