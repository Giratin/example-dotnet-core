using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduit.Models;

namespace GestionProduit.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        public static List<Category> Categories = new List<Category>(){
            new Category(){ CategoryID = 1, Name = "cat 1" },
            new Category(){ CategoryID = 2, Name = "cat 2" },
            new Category(){ CategoryID = 3, Name = "cat 3" },
        };

        public IEnumerable<Category> getAll()
        {
            return Categories;
        }
    }
}