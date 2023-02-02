using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

public class User
{
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string FullName { get; set; }
    [Required,MaxLength(50)]
    public string Email { get; set; }
    [Required,MaxLength(20)]
    public string PhoneNumber { get; set; }
    [Required,MinLength(5),MaxLength(50)]
    public string Password { get; set; }
    
}