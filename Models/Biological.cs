namespace GestionProduit.Models
{
    public class Biological : Product
    {
        public string Herbs { get; set; }

        public override void GetDetails()
        {
            base.GetDetails();
        }

        public override void GetMyType()
        {
            System.Console.WriteLine("BIOLOGICAL");
        }
    }
}