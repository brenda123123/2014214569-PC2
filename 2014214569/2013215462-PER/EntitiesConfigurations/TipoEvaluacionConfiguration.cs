﻿using _2014214569_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214569_PER.EntitiesConfigurations
{
    public class TipoEvaluacionConfiguration : EntityTypeConfiguration<TipoEvaluacion>
    {
        public TipoEvaluacionConfiguration()
        {
            ToTable("TipoEvaluacion");
            HasKey(a => a.TipoEvaluacionID);

        }

    }
}