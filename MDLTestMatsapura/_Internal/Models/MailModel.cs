using System.ComponentModel.DataAnnotations;

namespace MDLTestMatsapura._Internal.Models
{
    internal class MailModel
    {
        [Key]
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string[] Recipients { get; set; }
    }
}