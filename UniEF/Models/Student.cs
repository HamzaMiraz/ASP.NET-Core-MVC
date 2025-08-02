using System.ComponentModel.DataAnnotations;

namespace UniEF.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name="Student Name")]
        [Required]
        public string Name { get; set; }
        public string Department { get; set; }
        
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
