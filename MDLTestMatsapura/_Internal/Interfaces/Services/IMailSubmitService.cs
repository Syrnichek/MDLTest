using MDLTestMatsapura._Internal.Models;

namespace MDLTestMatsapura._Internal.Interfaces.Services
{
    internal interface IMailSubmitService
    {
        public Task MailSubmit(MailModel mailModel);
    }
}