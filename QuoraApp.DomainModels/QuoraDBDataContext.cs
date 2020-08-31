using System.Data.Entity;

namespace QuoraApp.DomainModels
{
    public class QuoraDBDataContext:DbContext
    {
        public QuoraDBDataContext():base("QuoraDBContext")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Vote> Votes { get; set; }
    }
}
