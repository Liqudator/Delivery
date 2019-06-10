using System;
using System.Collections.Generic;
using Delivery.Domain;

namespace Delivery.Managers
{
    /// <summary>
    /// Интерфейс менеджера для работы с заказом.
    /// </summary>
    public interface IOrderManager : IGenericManager<Order>
    {
        /// <summary>
        /// Получить заказы по определенному городу.
        /// </summary>
        /// <param name="city">Город.</param>
        /// <returns>Список заказов.</returns>
        List<Order> GetByCity(string city);

        /// <summary>
        /// Получить заказы по указанной дате.
        /// </summary>
        /// <param name="date">Дата.</param>
        /// <returns>Список заказов.</returns>
        List<Order> GetByDate(DateTime date);

        /// <summary>
        /// Удалить заказ старше 1 года.
        /// </summary>
        void DeleteOlderOneYear();

        /// <summary>
        /// Удалить историю заказов.
        /// </summary>
        void DeleteHistory();
    }
}
