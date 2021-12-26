namespace GestionProduit.Models
{
    public class Chemical : Product
    {
        public string LabName { get; set; }
        public Address Address { get; set; }

        public override void GetDetails()
        {
            base.GetDetails();
        }

        public override void GetMyType()
        {
            System.Console.WriteLine("CHEMICAL");
        }

    }
}