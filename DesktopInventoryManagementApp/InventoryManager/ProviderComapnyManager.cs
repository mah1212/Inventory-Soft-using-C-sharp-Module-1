using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopInventoryManagementApp.Data_Access;
using DesktopInventoryManagementApp.Model;

namespace DesktopInventoryManagementApp.InventoryManager
{
    public class ProviderComapnyManager
    {
        ProviderCompanyDataAccess aProviderCompanyDataAccess = new ProviderCompanyDataAccess();
        public string Save(ProviderCompany aProviderCompany)
        {
            if (aProviderCompanyDataAccess.IsCodeUnique(aProviderCompany.Name) != null)
            {
                return "Provider or Dealer already exists";
            }
            string msg = aProviderCompanyDataAccess.Save(aProviderCompany);
            return msg;
        }

        public List<ProviderCompany> GetAll()
        {
            return aProviderCompanyDataAccess.GetAll();
        }
    }
}
