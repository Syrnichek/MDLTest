using MDLTestMatsapura.Models;
using MDLTestMatsapura.Models.Requests;

namespace MDLTestMatsapura.Interfaces.Services
{
    /// <summary>
    /// Сервис для отправления email, сохранения и получения параметров.
    /// </summary>
    public interface IMailsService
    {
        /// <summary>
        /// Отправление email и сохранение параметров.
        /// </summary>
        /// <param name="request"><see cref="MailRequest"/></param>
        public void MailCreate(MailRequest request);
        
        /// <summary>
        /// Получение параметров.
        /// </summary>
        /// <returns><see cref="MailModel"/></returns>
        public List<MailModel> MailsGet();
    }
}