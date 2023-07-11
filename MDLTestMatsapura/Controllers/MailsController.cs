using MDLTestMatsapura.Interfaces.Services;
using MDLTestMatsapura.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace MDLTestMatsapura.Controllers
{
    public class MailsController: Controller
    {
        private readonly IMailsService _mailsService;
        
        public MailsController(IMailsService mailsService)
        {
            _mailsService = mailsService;
        }

        [HttpPost]
        [Route("api/mails/MailCreate")]
        public void MailCreate([FromBody] MailRequest request)
        {
            _mailsService.MailCreate(request);
        }
        
        [HttpGet]
        [Route("api/mails/MailsGet")]
        public IActionResult MailsGet()
        {
            try
            {
                _mailsService.MailsGet();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(420, "Отзыв отсутсвует");
            }
        }
    }
}