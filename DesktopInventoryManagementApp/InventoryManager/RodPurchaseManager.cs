using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopInventoryManagementApp.Data_Access;
using DesktopInventoryManagementApp.Model;

namespace DesktopInventoryManagementApp.InventoryManager
{
    public class RodPurchaseManager
    {
        RodPurchaseDataAccess aRodPurchaseDataAccess = new RodPurchaseDataAccess();
        public string Save(RodPurchese aRodPurchese)
        {
            aRodPurchaseDataAccess.Save(aRodPurchese);
            return "Purchase info saved Successfully";
        }
    }
}
