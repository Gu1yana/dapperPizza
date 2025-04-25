using AdoNetHomeTask.Models;
using AdoNetHomeTask.Repositories;

namespace AdoNetHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productRepository = new ProductRepository();
            //List<ProductRepository>repositories = new List<ProductRepository>();
            //productRepository.Add("Test",10);
            productRepository.GetAll().ForEach(x =>
            {
                Console.WriteLine(x.Id + " " + x.Name);
            });
        }
    }
}
