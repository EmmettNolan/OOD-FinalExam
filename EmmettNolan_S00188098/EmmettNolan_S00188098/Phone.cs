using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmettNolan_S00188098
{
    public class Phone
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }
        public virtual List<Phone> Phones { get; set; }
        public int ID { get; set; }

        public Phone(string name, double price, string operatingSystems, string osImage, string phoneImage)
        {
            Name = name;
            Price = price;
            OperatingSystem = operatingSystems;
            OS_Image = osImage;
            Phone_Image = phoneImage;
        }

        public void IncreasePrice(double amount)
        {
            Price += amount * (1.1);
        }
    }

    public class PhoneData : DbContext
    {
        public PhoneData() : base("PhoneData") { }
        public DbSet<Phone> Phones { get; set; }
    }
}
