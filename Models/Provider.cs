using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionProduit.Models
{
    public class Provider : Concept
    {
        // private string confirmPassword;
        // public string ConfirmPassword
        // {
        //     get
        //     {
        //         return confirmPassword;
        //     }
        //     set
        //     {
        //         if (value == Password)
        //         {
        //             confirmPassword = value;
        //         }
        //         else
        //         {
        //             System.Console.WriteLine("Password and ConfirmPassword Does not match");
        //         }
        //     }
        // }
        public DateTime DateCreated { get; set; }

        [DataType(DataType.EmailAddress), Required]
        public string Email { get; set; }
        [Key]
        public int Id { get; set; }
        public bool IsApproved { get; set; }

        [MinLength(8), Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [MinLength(8), Required, DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        // private string password;

        // public string Password
        // {
        //     get { return password; }
        //     set
        //     {
        //         if (value.Length >= 5 && value.Length <= 20)
        //         {
        //             password = value;
        //         }
        //         else
        //         {
        //             System.Console.WriteLine("Password Length should be between 5 and 20 characters");
        //         }
        //     }
        // }
        public string Username { get; set; }
        public virtual List<Product> Products { get; set; }

        // public override void GetDetails()
        // {
        //     System.Console.WriteLine("Provider Details : Username : {0}", Username);
        //     foreach (var product in Products)
        //     {
        //         product.GetDetails();
        //     }
        // }
        public static void SetIsApproved(Provider p)
        {
            p.IsApproved = p.Password == p.ConfirmPassword;
        }


        public bool Login2(string Username, string password, string email = null)
        {
            return this.Username == Username && this.Password == password && (email == null || this.Email == email);

            // true || true false ==> true
            // false (1) || true false (2) ==> true false (2)
            //provider.Login2("","");
        }





        public static void SetIsApproved(string password, string confirmPassword, ref bool IsApproved)
        {
            IsApproved = password == confirmPassword;
        }
        public bool Login(string userName, string password)
        {
            return Username == userName && Password == password;
        }
        public bool Login(string userName, string password, string email = null)
        {
            return Username == userName && Password == password && (Email == email || email == null);
        }

        public override void GetDetails()
        {
            System.Console.WriteLine("Provider Username : {0}  ", Username);
        }

        // public void GetProducts(string filterType, string filterValue)
        // {
        //     filterType = filterType.ToLower();
        //     switch (filterType)
        //     {
        //         case "dateprod":
        //             {
        //                 foreach (var product in Products)
        //                 {
        //                     if (product.DateProd.Equals(DateTime.Parse(filterValue)))
        //                     {
        //                         product.GetDetails();
        //                     }
        //                 }
        //                 break;
        //             }
        //         case "name":
        //             {
        //                 foreach (var product in Products)
        //                 {
        //                     if (product.Name.Equals(filterValue))
        //                     {
        //                         product.GetDetails();
        //                     }
        //                 }
        //                 break;
        //             }
        //         case "quantity":
        //             {
        //                 foreach (var product in Products)
        //                 {
        //                     if (product.Quantity.Equals(Int16.Parse(filterValue)))
        //                     {
        //                         product.GetDetails();
        //                     }
        //                 }
        //                 break;
        //             }
        //         case "price":
        //             {
        //                 foreach (var product in Products)
        //                 {
        //                     if (product.Price.Equals(Double.Parse(filterValue)))
        //                     {
        //                         product.GetDetails();
        //                     }
        //                 }
        //                 break;
        //             }
        //     }
        // }
    }
}