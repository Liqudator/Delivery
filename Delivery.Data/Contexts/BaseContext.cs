using Microsoft.EntityFrameworkCore;

namespace Delivery.Data.Contexts
{
    /// <summary>
    /// Базовый контекст.
    /// </summary>
    public class BaseContext<TEntity> : DbContext
        where TEntity : class
    {
        public virtual DbSet<TEntity> Entities { get; set; }
    }
}
