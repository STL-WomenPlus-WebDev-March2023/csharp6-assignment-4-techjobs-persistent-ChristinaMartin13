using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required (ErrorMessage = "Job name is required.")]
        [StringLength(50, ErrorMessage = "Job name must not exceed 50 characters.")]
        public string? Name { get; set; }
        public int EmployerId { get; set; }

        public List<SelectListItem>? Employers { get; set; }
    }
}
