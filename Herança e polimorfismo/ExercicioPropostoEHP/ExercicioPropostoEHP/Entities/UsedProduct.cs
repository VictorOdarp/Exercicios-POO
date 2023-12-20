
using System.Globalization;

namespace ExercicioPropostoEHP.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManuafactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manuafactureDate) : base (name, price)
        {
            ManuafactureDate = manuafactureDate;
        }

        public override string priceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + ManuafactureDate.ToString("dd/MM/yyyy)");
        }
    }

    
}
