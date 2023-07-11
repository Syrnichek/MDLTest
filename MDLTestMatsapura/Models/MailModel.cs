using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MDLTestMatsapura.Models
{
    public class MailModel
    {
        [Key]
        public int Id { get; set; }

        public string? Subject { get; set; }

        public string? Body { get; set; }

        public string[]? Recipients { get; set; }

        public DateTime DateTime { get; set; }
        
        public string? Result { get; set; }

        public string? FailedMessage { get; set; }
    }
}