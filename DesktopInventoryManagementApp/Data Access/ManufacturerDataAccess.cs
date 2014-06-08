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
    public class ManufacturerDataAccess
    {


        private string connectionString = null;

        public ManufacturerDataAccess()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["InventoryManagementDbConectionString"].ConnectionString;
        }

        public string Save(Manufacturer aManufacturer)
        {
            string query = "INSERT INTO t_manufacturer(name) VALUES ('" + aManufacturer.Name + "')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Manufacturer saved";
        }

        

        public List<Manufacturer> GetAll()
        {
            string query = "SELECT * FROM t_manufacturer";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Manufacturer> manufacturers = new List<Manufacturer>();

            while (sqlDataReader.Read())
            {
                Manufacturer aManufacturer = new Manufacturer();
                aManufacturer.Id = Convert.ToInt32(sqlDataReader[0]);
                aManufacturer.Name = sqlDataReader[1].ToString();
                manufacturers.Add(aManufacturer);
            }
            sqlConnection.Close();
            return manufacturers;
        }

        public Manufacturer IsCodeUnique(string name)
        {
            string query = "SELECT * FROM t_manufacturer where name = '" + name + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Manufacturer aManufacturer = new Manufacturer();
                aManufacturer.Name = sqlDataReader[1].ToString();
                sqlConnection.Close();
                return aManufacturer;
            }
            sqlConnection.Close();
            return null;
        }
    }
}
