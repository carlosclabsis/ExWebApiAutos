using ExWebApiAutos.Model.ExWebApiAutosDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExWebApiAutos.Model.Repositories
{
    public interface IMarcaRepository
    {
        IQueryable<TMarca> Marcas { get; }

        void SaveMarca(TMarca marca);

        void DeleteMarca(Guid MarcaID);
    }
}
