using System.Data.Entity;
using Task.Data.Model;

namespace Task.Data
{
    public class EFBlogContext : DbContext
    {
        public EFBlogContext()
            : base("BlogContext")
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> ProjectTasks { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<FeedComment> FeedComments { get; set; }
        public DbSet<FeedNote> FeedNotes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<CurrencyRecord> CurrencyRecords { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // İlişkileri kuruyoruz one-to-many olarak.
          

            base.OnModelCreating(modelBuilder);
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}