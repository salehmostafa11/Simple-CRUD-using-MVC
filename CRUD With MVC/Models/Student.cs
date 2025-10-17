using System.ComponentModel.DataAnnotations;

namespace CRUD_With_MVC.Models
{
    public class Student
    {
        [Key]
        [Display(Name ="Student Id")]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name ="Student Name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        [Display(Name ="Ennrolement Date")]
        public DateTime EnnrolmentDate { get; set; }
    }
}
