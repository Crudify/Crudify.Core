using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crudify.Core.Interfaces
{
    public interface ICrudRepository<TCrudEntity, TCrudEntityId> : IDisposable
            where TCrudEntity : ICrudEntity<TCrudEntityId>
            where TCrudEntityId : struct
    {
        TCrudEntityId Create(TCrudEntity crudEntity);

        Task<TCrudEntityId> CreateAsync(TCrudEntity crudEntity);

        TCrudEntityId Read(TCrudEntityId crudEntityId);

        Task<TCrudEntityId> ReadAsync(TCrudEntityId crudEntityId);

        void Update(TCrudEntity crudEntity);

        Task UpdateAsync(TCrudEntity crudEntity);

        void Delete(TCrudEntityId crudEntityId);

        Task DeleteAsync(TCrudEntityId crudEntityId);
    }
}
