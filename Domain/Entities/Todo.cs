using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Todo
{
    public int Id { get; set; }
    [Required, MaxLength(50)]
    public string Title { get; set; }
    [Required, MaxLength(100)]
    public string Description { get; set; }
    [Column(TypeName = "date")]
    public DateTime Deadline { get; set; }
    [Column(TypeName = "date")]
    public DateTime UpdatedAt { get; set; }
    [Column(TypeName = "date")]
    public DateTime CreatedAt { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
    public List<Comment> Comments { get; set; }

    public Todo()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}