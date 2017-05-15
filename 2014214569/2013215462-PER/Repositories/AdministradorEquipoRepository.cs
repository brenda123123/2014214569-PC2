using _2014214569_ENT;
using _2014214569_ENT.lRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214569_PER.Repositories
{
    public class AdministradorEquipoRepository : Repository<AdministradorEquipo>, IAdministradorEquipoRepository
    {
        private readonly BrendaDbContext _Context;

        public AdministradorEquipoRepository(BrendaDbContext context)
        {
            _Context = context;
        }

        private AdministradorEquipoRepository() { }

        IEnumerable<AdministradorEquipo> IAdministradorEquipoRepository.GetAdministradorEquipoWithEquipoCelular(int pageindex, int pageSize)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.add(AdministradorEquipo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.addRange(IEnumerable<AdministradorEquipo> entities)
        {
            throw new NotImplementedException();
        }

        AdministradorEquipo IRepository<AdministradorEquipo>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<AdministradorEquipo> IRepository<AdministradorEquipo>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<AdministradorEquipo> IRepository<AdministradorEquipo>.Find(System.Linq.Expressions.Expression<Func<AdministradorEquipo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.Update(AdministradorEquipo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.UpdateRange(IEnumerable<AdministradorEquipo> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.Delete(AdministradorEquipo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.DeleteRange(IEnumerable<AdministradorEquipo> entities)
        {
            throw new NotImplementedException();
        }
    }
}
