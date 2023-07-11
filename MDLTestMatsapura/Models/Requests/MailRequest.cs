namespace MDLTestMatsapura.Models.Requests
{
    public class MailRequest
    {
        public string Subject { get; set; }

        public string Body { get; set; }

        public string[] Recipients { get; set; }
    }
}