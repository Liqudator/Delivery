using System;

namespace Delivery.Domain
{
    /// <summary>
    /// Модель заказа.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// ИД заказа.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Описание заказа.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Сумма заказа.
        /// </summary>
        public double Sum { get; set; }

        /// <summary>
        /// Дата-время заказа.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// ИД покупателя.
        /// </summary>
        public int BuyerId { get; set; }

        /// <summary>
        /// ИД продавца.
        /// </summary>
        public int SellerId { get; set; }
    }
}
