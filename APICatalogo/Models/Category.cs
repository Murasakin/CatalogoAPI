using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Models;

//instead of data anotations, fluent API can be used to avoid pollution in our
//model/entity class

public class Category {

    public Category() {
        Products = new Collection<Product>();
    }

    [Key]
    public int CategoryId { get; set; }
    [Required]
    [StringLength(80)]
    public string? Name { get; set; }
    [Required]
    [StringLength(300)]
    public string? ImageUrl { get; set; }

    public ICollection<Product>? Products { get; set; }
}

