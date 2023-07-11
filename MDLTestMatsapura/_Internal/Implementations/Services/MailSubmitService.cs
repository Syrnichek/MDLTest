using MailKit.Net.Smtp;
using MDLTestMatsapura._Internal.Interfaces.Services;
using MDLTestMatsapura.Models;
using MDLTestMatsapura.Models.Requests;
using MimeKit;

namespace MDLTestMatsapura._Internal.Implementations.Services
{
    internal class MailSubmitService : IMailSubmitService
    {
        private readonly IConfiguration _configuration;
        
        public MailSubmitService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MailModel MailSubmit(MailRequest mailRequest)
        {
            var fromAddress = _configuration["Smtp:FromAddress"];
            var host = _configuration["Smtp:Host"];
            var port = _configuration.GetValue<int>("Smtp:Port");
            var userName = _configuration["Smtp:UserName"];
            var password = _configuration["Smtp:Password"];
            var message = new MimeMessage();
            
            message.From.Add(new MailboxAddress(fromAddress, fromAddress));
            foreach (var recipientAddress in mailRequest.Recipients)
            {
                message.To.Add(new MailboxAddress(recipientAddress, recipientAddress));
            }
            message.Subject = mailRequest.Subject;
            message.Body = new TextPart() {Text = mailRequest.Body};
            
            using (var client = new SmtpClient())
            {
                try
                {
                    if (!client.IsConnected)
                    {
                        client.Connect(host, port, true);
                    }

                    if (!client.IsAuthenticated)
                    {
                        client.Authenticate(userName, password);
                    }

                    client.Send(message);
                    client.Disconnect(true);
                    return new MailModel
                    {
                        Subject = mailRequest.Subject,
                        Body = mailRequest.Body,
                        Recipients = mailRequest.Recipients,
                        DateTime = DateTime.UtcNow,
                        Result = "Ok"
                    };
                }
                catch(Exception ex)
                {
                    return new MailModel
                    {
                        Subject = mailRequest.Subject,
                        Body = mailRequest.Body,
                        Recipients = mailRequest.Recipients,
                        DateTime = DateTime.UtcNow,
                        Result = "Failed",
                        FailedMessage = ex.Message
                    };
                }
            }
        }
    }
}