using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Models
{
    public class FitnessContext : DbContext
    {
        public FitnessContext(DbContextOptions<FitnessContext> options) : base(options)
        { }

        public DbSet<Member> Members { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Member data
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    MemberId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@email.com",
                    Age = 28,
                    Phone = "(555) 123-4567",
                    MembershipType = "Premium",
                    JoinDate = DateTime.Parse("2023-01-15"),
                    IsActive = true
                },
                new Member
                {
                    MemberId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@email.com",
                    Age = 32,
                    Phone = "(555) 987-6543",
                    MembershipType = "Basic",
                    JoinDate = DateTime.Parse("2023-03-22"),
                    IsActive = true
                },
                new Member
                {
                    MemberId = 3,
                    FirstName = "Mike",
                    LastName = "Johnson",
                    Email = "mike.johnson@email.com",
                    Age = 25,
                    Phone = "(555) 456-7890",
                    MembershipType = "Premium",
                    JoinDate = DateTime.Parse("2023-05-10"),
                    IsActive = true
                },
                new Member
                {
                    MemberId = 4,
                    FirstName = "Sarah",
                    LastName = "Wilson",
                    Email = "sarah.wilson@email.com",
                    Age = 29,
                    Phone = "(555) 234-5678",
                    MembershipType = "Standard",
                    JoinDate = DateTime.Parse("2023-07-08"),
                    IsActive = true
                }
            );
        }
    }
}