namespace ADO.NET_DZ_J
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Reflection.Emit;

    public class Context : DbContext
    {
        public Context()
            : base("name=Context1")
        {
        }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Signatures> Signatures { get; set; }

    }
}