using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionProduit.Models
{
    public class Category : Concept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
        public override void GetDetails()
        {
            System.Console.WriteLine("Category Name : {0}", Name);
        }

    }
}