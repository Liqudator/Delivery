using System;
using System.Collections.Generic;
using Delivery.Domain;

namespace Delivery.Services
{
    /// <summary>
    /// Интерфейс сервиса для работы с заказом.
    /// </summary>
    public interface IOrderService : IGenericService<Order>
    {
        /// <summary>
        /// Получить все заказы по указанной дате.
        /// </summary>
        /// <param name="date">Дата.</param>
        /// <returns>Список заказов.</returns>
        List<Order> GetByDate(DateTime date);

        /// <summary>
        /// Получить заказы по определенному городу
        /// </summary>
        /// <param name="city">Город.</param>
        /// <returns>Список заказов.</returns>
        List<Order> GetByCity(string city);

        /// <summary>
        /// Удалить заказ старше года.
        /// </summary>
        void DeleteOlderOneYear();

        /// <summary>
        /// Удалить историю заказов старше года.
        /// </summary>
        void DeleteHistoryOlderOneYear();
    }
}
