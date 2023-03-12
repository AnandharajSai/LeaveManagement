using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name="Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name="Default Number of Day")]
        [Required]
        [Range(0,100,ErrorMessage ="Please enter value between 1 to 100")]
        public int DefaultDays { get; set; }
    }
}
