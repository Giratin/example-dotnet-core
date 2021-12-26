using System.Collections.Generic;
using GestionProduit.Models;

namespace GestionProduit.Repositories
{
    public interface IProductRepo
    {
        IEnumerable<Product> getAll();
        Product getById(int id);
        bool createProduct(Product product);
        void createNewProduct(Product product);
        IEnumerable<Product> getList();
        IEnumerable<Product> getByCategoryId(int id);
    }
}