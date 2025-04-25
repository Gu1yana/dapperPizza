using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetHomeTask.Models;

public class Product
{
    public Product() { }
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}
