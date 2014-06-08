using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopInventoryManagementApp.Data_Access;
using DesktopInventoryManagementApp.Model;

namespace DesktopInventoryManagementApp.InventoryManager
{
    public class RodSizeManager
    {
        RodSizeDataAccess aRodSizeDataAccess = new RodSizeDataAccess();
        public string Save(RodSize aRodSize)
        {
            if (RodSizeDataAccess.IsSizeUnique(aRodSize.Size) != null)
            {
                return "Size already exists";
            }
            string msg = RodSizeDataAccess.Save(aRodSize);
            return msg;
        }

        public List<RodSize> GetAll()
        {
            return RodSizeDataAccess.GetAll();
        }
    }
}
