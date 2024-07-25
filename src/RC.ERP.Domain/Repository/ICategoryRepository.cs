using RC.ERP.Domain.Entity;
using RC.ERP.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC.ERP.Domain.Repository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        public Task<IReadOnlyList<Guid>> GetIdsListByIds(List<Guid> ids, CancellationToken cancellationToken);

        public Task<IReadOnlyList<Category>> GetListByIds(List<Guid> ids, CancellationToken cancellationToken);
    }
}
