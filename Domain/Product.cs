using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalogo.Domain;

public class Product
{
    public int Id { get; set; }

    [Required] [StringLength(80)] public string? Name { get; set; }

    [Required] [StringLength(300)] public string? Description { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }

    [Required] [StringLength(300)] public string? ImageUrl { get; set; }

    public float Quantity { get; set; }

    public DateTime DateCreated { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}