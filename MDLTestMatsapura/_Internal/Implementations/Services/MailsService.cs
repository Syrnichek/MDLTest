using MDLTestMatsapura._Internal.Implementations.Data;
using MDLTestMatsapura._Internal.Interfaces.Services;
using MDLTestMatsapura.Interfaces.Services;
using MDLTestMatsapura.Models;
using MDLTestMatsapura.Models.Requests;
using Microsoft.EntityFrameworkCore;

namespace MDLTestMatsapura._Internal.Implementations.Services
{
    internal class MailsService : IMailsService
    {
        private readonly IMailSubmitService _mailSubmitService;
        
        public MailsService(IMailSubmitService mailSubmitService)
        {
            _mailSubmitService = mailSubmitService;
        }

        public void MailCreate(MailRequest request)
        {
            var mail = _mailSubmitService.MailSubmit(request);
            
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder.Options;
            
            using (ApplicationContext applicationContext = new ApplicationContext(options))
            {
                applicationContext.Mails.Add(mail);
                applicationContext.SaveChanges();
            }
        }

        public List<MailModel> MailsGet()
        {
            throw new NotImplementedException();
        }
    }
}