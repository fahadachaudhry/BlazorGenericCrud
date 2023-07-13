using Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ORM.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        private IConfigurationRoot _configuration { get; set; }
        public AppDbContext()
        {
            InitConfigurations();
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            InitConfigurations();
        }

        private void InitConfigurations()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserProfile>().HasData(new UserProfile
            {
                Id = "7d0f3035-8216-4537-971e-734f05ad7dc1",
                Name = "Some Name",
                Department = "Department Comes Here",
                Description = "This is some description",
                Designation = "This is the Designation",
            });
            modelBuilder.Entity<UserProfile>().HasData(new UserProfile
            {
                Id = "7d0f3035-8216-4537-971e-734f05ad7dc2",
                Name = "Some Name",
                Department = "Department Comes Here",
                Description = "This is some description",
                Designation = "This is the Designation",
            });
            modelBuilder.Entity<UserProfile>().HasData(new UserProfile
            {
                Id = "7d0f3035-8216-4537-971e-734f05ad7dc3",
                Name = "Some Name",
                Department = "Department Comes Here",
                Description = "This is some description",
                Designation = "This is the Designation",
            });
            modelBuilder.Entity<UserProfile>().HasData(new UserProfile
            {
                Id = "7d0f3035-8216-4537-971e-734f05ad7dc4",
                Name = "Some Name",
                Department = "Department Comes Here",
                Description = "This is some description",
                Designation = "This is the Designation",
            });
            modelBuilder.Entity<UserProfile>().HasData(new UserProfile
            {
                Id = "7d0f3035-8216-4537-971e-734f05ad7dc5",
                Name = "Some Name",
                Department = "Department Comes Here",
                Description = "This is some description",
                Designation = "This is the Designation",
            });
            modelBuilder.Entity<UserProfile>().HasData(new UserProfile
            {
                Id = "7d0f3035-8216-4537-971e-734f05ad7dc6",
                Name = "Some Name",
                Department = "Department Comes Here",
                Description = "This is some description",
                Designation = "This is the Designation",
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_configuration != null)
            {
                string connectionString = _configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
                optionsBuilder.UseMySql(
                    connectionString,
                    ServerVersion.AutoDetect(connectionString));
            }
        }
        public virtual DbSet<TodoItem> TodoItems { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
    }
}
