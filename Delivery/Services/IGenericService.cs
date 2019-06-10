using System.Collections.Generic;

namespace Delivery.Services
{
    /// <summary>
    /// Базовый сервис.
    /// </summary>
    public interface IGenericService<TEntity>
    {
        /// <summary>
        /// Создать сущность.
        /// </summary>
        /// <param name="entity">Информация о сущности.</param>
        /// <returns>Сущность.</returns>
        TEntity Create(TEntity entity);

        /// <summary>
        /// Получить сущность.
        /// </summary>
        /// <param name="id">ИД сущности.</param>
        /// <returns>Сущность.</returns>
        TEntity Get(int id);

        /// <summary>
        /// Получить все сущности.
        /// </summary>
        /// <returns>Список сущностей.</returns>
        List<TEntity> GetAll();

        /// <summary>
        /// Изменить сущность.
        /// </summary>
        /// <param name="entity">Информация о сущности.</param>
        /// <returns>Сущность.</returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Удалить сущность.
        /// </summary>
        /// <param name="id">ИД сущности.</param>
        void Delete(int id);
    }
}
