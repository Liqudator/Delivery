namespace Delivery.Domain
{
    /// <summary>
    /// Базовая модель субъекта.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ИД.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Город проживания.
        /// </summary>
        public string City { get; set; }
    }
}
