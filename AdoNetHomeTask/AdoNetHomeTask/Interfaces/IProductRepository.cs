using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetHomeTask.Interfaces;

public interface IProductRepository<T>
{
    int Add(T model);
    List<T> ProductsView();
    void Delete(int id);
    int Update(int id,T model);
}
