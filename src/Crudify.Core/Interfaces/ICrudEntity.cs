using System;
using System.Collections.Generic;
using System.Text;

namespace Crudify.Core.Interfaces
{
    public interface ICrudEntity<TCrudEntityId> where TCrudEntityId : struct
    {
        TCrudEntityId Id { get; set; }
    }
}
