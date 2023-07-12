using MDLTestMatsapura.Interfaces.Services;
using MDLTestMatsapura.Models;
using MDLTestMatsapura.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace MDLTestMatsapura.Controllers
{
    /// <summary>
    /// Контроллер для работы с email.
    /// </summary>
    public class MailsController: Controller
    {
        private readonly IMailsService _mailsService;
        
        /// <summary>
        /// .ctor
        /// </summary>
        public MailsController(IMailsService mailsService)
        {
            _mailsService = mailsService;
        }
        
        /// <summary>
        /// Отправление email и сохраненеие параметров в бд.
        /// </summary>
        /// <param name="request"><see cref="MailRequest"/></param>
        [HttpPost]
        [Route("api/mails/MailCreate")]
        public void MailCreate([FromBody] MailRequest request)
        {
            _mailsService.MailCreate(request);
        }
        
        /// <summary>
        /// Получение списка параметров из бд.
        /// </summary>
        /// <returns><see cref="MailModel"/></returns>
        [HttpGet]
        [Route("api/mails/MailsGet")]
        public List<MailModel> MailsGet()
        {
            return _mailsService.MailsGet();
        }
    }
}