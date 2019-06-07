namespace Delivery.Domain
{
    /// <summary>
    /// Модель продавца.
    /// </summary>
    public class Seller : Person
    {
        /// <summary>
        /// Размер комиссии в процентах.
        /// </summary>
        public double Comission { get; set; }
    }
}
