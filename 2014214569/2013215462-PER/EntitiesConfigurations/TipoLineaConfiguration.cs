﻿using _2014214569_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2014214569_PER.EntitiesConfigurations
{
    public class TipoLineaConfiguration : EntityTypeConfiguration<TipoLinea>
    {
        public TipoLineaConfiguration()
        {
            ToTable("TipoLinea");
            HasKey(a => a.TipoLineaID);
            
           
        }
    }
}
