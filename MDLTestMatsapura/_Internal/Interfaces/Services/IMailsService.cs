using MDLTestMatsapura._Internal.Models;

namespace MDLTestMatsapura._Internal.Interfaces.Services
{
    internal interface IMailsService
    {
        public Task MailCreate(MailModel mailModel);

        public List<MailModel> MailsGet();
    }
}