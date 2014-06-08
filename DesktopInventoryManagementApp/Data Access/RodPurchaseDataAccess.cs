using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopInventoryManagementApp.Model;

namespace DesktopInventoryManagementApp.Data_Access
{
    public class RodPurchaseDataAccess
    {
        
            private string connectionString = null;

            public RodPurchaseDataAccess()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["InventoryManagementDbConectionString"].ConnectionString;
        }
        public string Save(RodPurchese aRodPurchese)
        {
            string query = "INSERT INTO t_provider_company(name, contact) VALUES ('" + aRodPurchese.Manufacturer + "','"+aRodPurchese.ProviderCompany+"')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Provider Company info saved";
            
        }

        
    }
}
