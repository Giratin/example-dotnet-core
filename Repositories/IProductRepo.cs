using System.Collections.Generic;
using GestionProduit.Models;

namespace GestionProduit.Repositories
{
    public interface IProductRepo : IService<Product>
    {
        //signatures des méthodes spécifiques (sauf CRUD)
        IEnumerable<Product> getByCategoryId(int id);
        IEnumerable<Product> Get5ProductsByCayegory(string catname);
    }
}