using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_DZ_J
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var test = from s in context.Signatures
                           join d in context.Documents on s.DocumentId equals d.Id
                           join u in context.Users on s.UserId equals u.Id
                           join p in context.People on u.PersonId equals p.Id
                           join t in context.DocumentTypes on d.DocumentTypeId equals t.Id
                           select new
                           {
                               Theme = d.Theme,
                               Creator = d.User.Person.FullName,
                               CreationDate = d.CreationDate,
                               Signed = s.User.Person.FullName
                           };
            }
        }
    }
}
