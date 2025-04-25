using AdoNetHomeTask.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AdoNetHomeTask.Repositories;

public class ProductRepository
{
    const string connStr = "Server=.\\SQLEXPRESS;Database=PizzaMizza;Trusted_Connection=True;TrustServerCertificate=True;";
    SqlConnection _conn => new SqlConnection(connStr);
    //public Product GetById()
    //{

    //}
    public List<Product> GetAll()
    {
        using (_conn)
        {
            var list = _conn.Query<Product>("SELECT * FROM Products").ToList();
            return list;
        }
    }
    public void Add(string name, decimal price)
    {
        using (_conn)
        {
            _conn.Execute($"INSERT INTO Products VALUES (N'{name}',{price})");
        }
    }

    public void Delete(int id)
    {
        
    }
    public void Update(int id, Product model)
    {
      
    }
}
