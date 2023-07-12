namespace MDLTestMatsapura.Models.Requests
{
    /// <summary>
    /// Модель получения параметров для отправки email.
    /// </summary>
    public class MailRequest
    {
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
    }
}