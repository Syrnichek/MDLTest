using MDLTestMatsapura.Models;
using MDLTestMatsapura.Models.Requests;

namespace MDLTestMatsapura._Internal.Interfaces.Services
{
    internal interface IMailSubmitService
    {
        public MailModel MailSubmit(MailRequest MailRequest);
    }
}