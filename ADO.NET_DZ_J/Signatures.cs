using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_DZ_J
{
    public class Signatures
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Document")]
        public int DocumentId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public Document Document { get; set; }
        public User User { get; set; }
    }
}
