﻿using _2013215462_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013215462_PER.EntitiesConfigurations
{
    public class TipoPlanConfiguration : EntityTypeConfiguration<TipoPlan>
    {
        public TipoPlanConfiguration()
        {
            ToTable("TipoPlan");
            HasKey(a => a.TipoPlanID);

            Property(a => a.TipoPlanID)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Property(v => v.Descripcion)
            // .IsRequired()
            // .HasMaxLength(255);


        }
    }
}