using MDLTestMatsapura._Internal.Models;
using MDLTestMatsapura._Internal.Models.Requests;

namespace MDLTestMatsapura._Internal.Interfaces.Services
{
    internal interface IMailsService
    {
        public Task MailCreate(MailRequest request);

        public List<MailModel> MailsGet();
    }
}