﻿using _2014214569_ENT;
using _2014214569_ENT.lRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214569_PER.Repositories
{
    class TrabajadorRepository : Repository<Trabajador>, ITrabajadorRepository
    {
        private BrendaDbContext _Context;

        public TrabajadorRepository(BrendaDbContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }

        private TrabajadorRepository()
        {

        }
    }
}