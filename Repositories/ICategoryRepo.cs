using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduit.Models;

namespace GestionProduit.Repositories
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> getAll();
    }
}