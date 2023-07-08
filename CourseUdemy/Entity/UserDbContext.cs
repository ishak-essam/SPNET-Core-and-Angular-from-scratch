using Microsoft.EntityFrameworkCore;

namespace CourseUdemy.Entity
{
    public class UserDbContext : DbContext
    {
        public UserDbContext ( DbContextOptions options ) : base (options)
        {
        }
        public  DbSet<User> users { get; set; }
    }
}
