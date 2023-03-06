using System.ComponentModel.DataAnnotations;

namespace AspNetCoreWebApi.Models
{
    public class DeleteSchoolFormModel
    {
        [Required]
        public string? SchoolId { get; set; }
    }
}
