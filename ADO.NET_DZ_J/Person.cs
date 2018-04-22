using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_DZ_J
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}
