using System.ComponentModel.DataAnnotations;

namespace AW_MVC_uppgift_3.Views.Employees
{
    public class CreateVM
    {
        [Required(ErrorMessage = "Enter a name")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress]
        [Required(ErrorMessage = "Enter a e-mail")]
        public string Email { get; set; }
        [Display(Name = "What is 2 + 2?")]
        [Range(4,4)]
        [Required(ErrorMessage = "Enter correct answer")]
        public int BoxCheck { get; set; }
    }
}
