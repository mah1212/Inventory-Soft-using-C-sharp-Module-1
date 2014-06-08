using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopInventoryManagementApp.Data_Access;
using DesktopInventoryManagementApp.Model;

namespace DesktopInventoryManagementApp.InventoryManager
{
    public class RodQualityManager
    {
        RodQualityDataAccess aRodQualityDataAccess = new RodQualityDataAccess();
        public string Save(RodQuality aRodQuality)
        {
            if (aRodQualityDataAccess.IsQualityUnique(aRodQuality.Quality) != null)
            {
                return "Quality already exists";
            }
            string msg = aRodQualityDataAccess.Save(aRodQuality);
            return msg;   
        }

        public List<RodQuality> GetAll()
        {
            return aRodQualityDataAccess.GetAll();
        }
    }
}
