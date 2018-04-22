using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_DZ_J
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public string Theme { get; set; }
        [ForeignKey("DocumentType")]
        public int DocumentTypeId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ReviewDate { get; set; }
        ICollection<Signatures> Signatures { get; set; }
        public DocumentType DocumentType { get; set; }
        public User User { get; set; }
    }
}
