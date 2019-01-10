using Repository.Entities;
using System.Data.Entity;

namespace Repository.Contexts {
    public class MainContext : DbContext {
        public MainContext()
            : base("DbConnection") {
        }

        public DbSet<Friend> Users {
            get; set;
        }
    }
}
