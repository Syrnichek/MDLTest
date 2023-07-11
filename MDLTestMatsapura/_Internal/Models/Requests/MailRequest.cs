namespace MDLTestMatsapura._Internal.Models.Requests
{
    internal class MailRequest
    {
        public string Subject { get; set; }

        public string Body { get; set; }

        public string[] Recipients { get; set; }
    }
}