﻿using _2014214569_ENT;
using _2014214569_ENT.lRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214569_PER.Repositories
{
    class ProvinciaRepository : Repository<Provincia>, IProvinciaRepository
    {
        private BrendaDbContext _Context;

        public ProvinciaRepository(BrendaDbContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }

        private ProvinciaRepository()
        {

        }
    }
}