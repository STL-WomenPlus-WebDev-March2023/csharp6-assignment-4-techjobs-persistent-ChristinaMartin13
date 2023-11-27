using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Employer name is required.")]
        [StringLength(50,ErrorMessage = "Employer name must not exceed 50 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Employer location is required.")]
        [StringLength(50, ErrorMessage = "Employer location must not exceed 50 characters.")]
        public string? Location { get; set; }
    }

    
}
