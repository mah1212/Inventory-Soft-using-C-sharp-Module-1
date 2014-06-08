using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopInventoryManagementApp.Data_Access;
using DesktopInventoryManagementApp.Model;

namespace DesktopInventoryManagementApp.InventoryManager
{
    public class ManufacturerManager
    {
        ManufacturerDataAccess _aManufacturerDataAccess = new ManufacturerDataAccess();
        public string Save(Manufacturer aManufacturer)
        {
            if (_aManufacturerDataAccess.IsCodeUnique(aManufacturer.Name) != null)
            {
                return "Manufacturer already exists";
            }
            string msg = _aManufacturerDataAccess.Save(aManufacturer);
            return msg;
        }

        public List<Manufacturer> GetAll()
        {
            return _aManufacturerDataAccess.GetAll();
        }

        
    }
}
