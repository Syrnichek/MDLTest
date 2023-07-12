using System.ComponentModel.DataAnnotations;

namespace MDLTestMatsapura.Models
{
    /// <summary>
    /// Модель для загрузки параметров в бд.
    /// </summary>
    public class MailModel
    {
        /// <summary>
        /// Id сообщения.
        /// </summary>
        [Key]
        public int Id { get; set; }
        
        /// <summary>
        /// Тема сообщения.
        /// </summary>
        public string? Subject { get; set; }
        
        /// <summary>
        /// Тело сообщения.
        /// </summary>
        public string? Body { get; set; }
        
        /// <summary>
        /// Получатели.
        /// </summary>
        public string[]? Recipients { get; set; }
        
        /// <summary>
        /// Дата и время отправки сообщения.
        /// </summary>
        public DateTime DateTime { get; set; }
        
        /// <summary>
        /// Результат отправки сообщения.
        /// </summary>
        public string? Result { get; set; }
        
        /// <summary>
        /// Поле текста ошибки отправки сообщения.
        /// </summary>
        public string? FailedMessage { get; set; }
    }
}