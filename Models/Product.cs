using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionProduit.Models
{
    public class Product : Concept
    {
        public int ProductId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateProd { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [MaxLength(50, ErrorMessage = "Storage max = 50")]
        [StringLength(25, ErrorMessage = "User Input Max Length Allowed is 25 Character")]
        public string Name { get; set; }
        [Range(0, Int16.MaxValue)]
        public Int16 Quantity { get; set; }
        [DataType(DataType.Currency)]
        public Double Price { get; set; }

        public Int32? CatgoryId { get; set; } // Nullable
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
        public virtual List<Provider> Providers { get; set; }
        public virtual IList<Facture> Factures { get; set; }

        public override void GetDetails()
        {
            System.Console.WriteLine("Product ID: {2}, Name: {0}, Quantity: {1}", Name, Quantity, ProductId);
        }

        public virtual void GetMyType()
        {
            System.Console.WriteLine("UNKNOWN");
        }

        public void GetMyType2()
        {
            // if (this is Product)
            // {
            //     System.Console.WriteLine("PRODUCT");
            // }
            // else
            if (this is Chemical)
            {
                System.Console.WriteLine("CHEMICAL");
            }
            else if (this is Biological)
            {
                System.Console.WriteLine("BIOLOGICAL");
            }
            else
            {
                System.Console.WriteLine("PRODUCT");
            }
        }
    }
}