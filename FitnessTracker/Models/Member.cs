using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Models
{
    public class Member
    {
        // Primary Key
        public int MemberId { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        [StringLength(50, ErrorMessage = "First name must be 50 characters or less.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your last name.")]
        [StringLength(50, ErrorMessage = "Last name must be 50 characters or less.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email address.")]
        [StringLength(100, ErrorMessage = "Email must be 100 characters or less.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your age.")]
        [Range(13, 120, ErrorMessage = "Age must be between 13 and 120.")]
        public int? Age { get; set; }

        [StringLength(20, ErrorMessage = "Phone number must be 20 characters or less.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please select a membership type.")]
        [StringLength(30, ErrorMessage = "Membership type must be 30 characters or less.")]
        public string MembershipType { get; set; } = string.Empty;

        public DateTime JoinDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        // Computed property for display
        public string FullName => $"{FirstName} {LastName}";
    }
}