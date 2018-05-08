using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Crudify.Core
{
    public interface ICrudRepository<TCrudEntity, TCrudEntityId> : IDisposable
            where TCrudEntity : class, ICrudEntity<TCrudEntityId>
            where TCrudEntityId : struct
    {
        TCrudEntityId Create(TCrudEntity crudEntity);

        Task<TCrudEntityId> CreateAsync(TCrudEntity crudEntity);

        TCrudEntity Read(TCrudEntityId crudEntityId);

        Task<TCrudEntity> ReadAsync(TCrudEntityId crudEntityId);

        void Update(TCrudEntity crudEntity);

        Task UpdateAsync(TCrudEntity crudEntity);

        void Delete(TCrudEntityId crudEntityId);

        Task DeleteAsync(TCrudEntityId crudEntityId);
    }
}
