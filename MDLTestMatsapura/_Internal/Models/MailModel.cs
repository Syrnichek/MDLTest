using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MDLTestMatsapura._Internal.Models
{
    internal class MailModel
    {
        [Key]
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string[] Recipients { get; set; }

        public DateTime DateTime { get; set; }
        
        [NotMapped]
        public IResult Result { get; set; }
    }
}