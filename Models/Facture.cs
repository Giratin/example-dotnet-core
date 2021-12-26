using System;

namespace GestionProduit.Models
{
    public class Facture
    {
        public DateTime DateAchat { get; set; }
        public Double Prix { get; set; }
        public int ProductFk { get; set; }
        public virtual Product Product { get; set; }
        public int ClientFk { get; set; }
        public virtual Client Client { get; set; }
    }
}