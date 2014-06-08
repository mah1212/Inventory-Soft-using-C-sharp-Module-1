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
    public class ProviderCompanyDataAccess
    {
        private string connectionString = null;

        public ProviderCompanyDataAccess()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["InventoryManagementDbConectionString"].ConnectionString;
        }
        public string Save(ProviderCompany aProviderCompany)
        {
            string query = "INSERT INTO t_provider_company(name, contact) VALUES ('" + aProviderCompany.Name + "','"+aProviderCompany.Contact+"')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Provider Company info saved";
            
        }

        public object IsCodeUnique(string name)
        {
            string query = "SELECT * FROM t_provider_company where name = '" + name + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                ProviderCompany aProviderCompany = new ProviderCompany();
                aProviderCompany.Name = sqlDataReader[1].ToString();
                sqlConnection.Close();
                return aProviderCompany;
            }
            sqlConnection.Close();
            return null;
        }

        public List<ProviderCompany> GetAll()
        {
            string query = "SELECT * FROM t_provider_company";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<ProviderCompany> providerCompanies = new List<ProviderCompany>();

            while (sqlDataReader.Read())
            {
                ProviderCompany aProviderCompany = new ProviderCompany();
                aProviderCompany.Id = Convert.ToInt32(sqlDataReader[0]);
                aProviderCompany.Name = sqlDataReader[1].ToString();
                aProviderCompany.Contact = sqlDataReader[2].ToString();
                providerCompanies.Add(aProviderCompany);
            }
            sqlConnection.Close();
            return providerCompanies;
        }
    }
}
