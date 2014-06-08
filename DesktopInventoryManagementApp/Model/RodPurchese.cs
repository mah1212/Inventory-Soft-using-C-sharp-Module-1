using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopInventoryManagementApp.Model
{
    public class RodPurchese
    {
        public int Id { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string PurchaseDate { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int ProviderCompanyId { get; set; }
        public ProviderCompany ProviderCompany { get; set; }
        public double Paid { get; set; }

        public double GetTotalPrice()
        {
            return UnitPrice * Quantity;
        }

        public double GetDueAmount()
        {
            return GetTotalPrice() - Paid;
        }

        
    }
}
