using MDLTestMatsapura.Models;
using MDLTestMatsapura.Models.Requests;

namespace MDLTestMatsapura.Interfaces.Services
{
    public interface IMailsService
    {
        public void MailCreate(MailRequest request);

        public List<MailModel> MailsGet();
    }
}