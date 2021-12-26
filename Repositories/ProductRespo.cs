using System;
using System.Collections.Generic;
using System.Linq;
using GestionProduit.Infrastuctures;
using GestionProduit.Models;

namespace GestionProduit.Repositories
{
    public class ProductRespo : Service<Product>, IProductRepo
    {
        public ProductRespo(IUnitOfWork utk) : base(utk)
        { }

        public IEnumerable<Product> Get5ProductsByCayegory(string catname)
        {
            return GetMany(p => p.Category.Name.Contains(catname)).ToList().Take(5);
        }

        public IEnumerable<Product> getByCategoryId(int id)
        {
            return GetMany(p => p.Category.CategoryID == id).ToList().Take(5);
        }
    }
}