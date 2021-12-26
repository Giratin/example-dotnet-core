using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionProduit.Data;
using GestionProduit.Models;

namespace GestionProduit.Repositories
{
    public class ProductRespo : IProductRepo
    {


        public List<Product> products = new List<Product>(){
                new Product(){ ProductId= 1, Name = "Product 1", DateProd= new DateTime(2012,12,12) , Description= "description product 1", Category= CategoryRepo.Categories[0] },
                new Product(){ ProductId= 2, Name = "Product 2", DateProd= new DateTime(2013,02,28) , Description= "description product 2", Category= CategoryRepo.Categories[2] },
                new Product(){ ProductId= 3, Name = "Product 3", DateProd= new DateTime(2021,03,30) , Description= "description product 3", Category= CategoryRepo.Categories[1] },
                new Product(){ ProductId= 4, Name = "Product 4", DateProd= new DateTime(2019,12,31) , Description= "description product 4", Category= CategoryRepo.Categories[0] },
                new Product(){ ProductId= 5, Name = "Product 5", DateProd= new DateTime(2018,05,25) , Description= "description product 5", Category= CategoryRepo.Categories[0] },
            };



        private readonly GPContext context;

        public ProductRespo()
        {
            context = new GPContext();
        }

        public void createNewProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public IEnumerable<Product> getList()
        {
            var products = context.Products.ToList();
            return products;
        }

        public bool createProduct(Product product)
        {
            var id = (products.Max(p => p.ProductId)) + 1;
            product.ProductId = id;
            products.Add(product);
            System.Console.WriteLine("Calling this method");
            foreach (var item in products)
            {
                item.GetDetails();
            }
            return true;
        }

        public IEnumerable<Product> getAll()
        {
            var products = context.Products.ToList();
            return products;
        }

        public IEnumerable<Product> getByCategoryId(int id)
        {
            var pds = (from p in products where p.Category.CategoryID == id select p).OrderBy(p => p.Name).ToList();
            return pds;
        }

        public Product getById(int id)
        {
            var product = (from p in products where p.ProductId == id select p).FirstOrDefault();
            return product;
        }
    }
}