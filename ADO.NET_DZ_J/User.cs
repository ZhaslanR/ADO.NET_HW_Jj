﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_DZ_J
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public ICollection<Document> Documents { get; set; }
        public Person Person { get; set; }
    }
}
