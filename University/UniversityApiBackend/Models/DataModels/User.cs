using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class User : BaseEntity
    {
       
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public ICollection<BaseEntity> BaseEntities { get; set; } = new List<BaseEntity>();

        [Required]
        public ICollection<Course> Courses { get; set; } = new List<Course>();

        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();

        [Required]
        public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();

        [Required]
        public ICollection<Category> Categories{ get; set; } = new List<Category>();

    }
}
