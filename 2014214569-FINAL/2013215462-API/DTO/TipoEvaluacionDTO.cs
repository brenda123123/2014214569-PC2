﻿using _2013215462_ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2013215462_API.DTO
{
    public class TipoEvaluacionDTO
    {
        public int TipoEvaluacionID { get; set; }

        //public string Descripcion { get; set; }
        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionID { get; set; }
    }
}