using System.Globalization;

namespace DemoInterface.Entities
{
    internal class CarRental 
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Invoice Invoice { get; set; }
        public Vehicle Vehicle { get; set; }


        public CarRental()
        {

        }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
