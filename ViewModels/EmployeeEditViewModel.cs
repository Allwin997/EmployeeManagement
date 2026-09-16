using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewModels;

public class EmployeeEditViewModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [StringLength(200)]
    public string Email { get; set; } = string.Empty;

    [Range(0, 10000000)]
    public decimal Salary { get; set; }

    [Required]
    public DateTime JoiningDate { get; set; }
}