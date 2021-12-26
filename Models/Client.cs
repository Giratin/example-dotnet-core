using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionProduit.Models
{
    public class Client
    {
        [Key]
        public int CIN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        //prop de navigation
        public virtual IList<Facture> Factures { get; set; }
    }
}