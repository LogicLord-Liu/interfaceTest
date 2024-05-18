using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceReview
{
    interface IElectrcial
    {
        string ProductionDate { get; set; }
        void Run();
    }
    public class TV : IElectrcial
    {
        public double Price { get; set; }
        public string Brand { get; set; }
        public TV(double price, string brand, string ProductionDate)
        {
            this.Brand = brand;
            this.ProductionDate = ProductionDate;
            this.Price = price;
        }

        private string _ProductionDate = "";
        public string ProductionDate
        {
            get { return _ProductionDate; }
            set { _ProductionDate = value; }
        }
        public void Run()
        {
            Console.WriteLine("The TV is Running");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Brand： " + Brand);
            Console.WriteLine("Price： " + Price);
            Console.WriteLine("ProductionDate： " + ProductionDate);
        }
    }
}
