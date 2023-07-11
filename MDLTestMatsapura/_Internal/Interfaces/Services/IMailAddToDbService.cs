using MDLTestMatsapura._Internal.Models;

namespace MDLTestMatsapura._Internal.Interfaces.Services
{
    internal interface IMailAddToDbService
    {
        public Task MailAddToDb(MailModel mailModel);
    }
}