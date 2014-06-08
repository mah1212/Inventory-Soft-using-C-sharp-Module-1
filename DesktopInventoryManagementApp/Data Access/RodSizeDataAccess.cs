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
    public class RodSizeDataAccess
    {
        private static string connectionString = null;

        public RodSizeDataAccess()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["InventoryManagementDbConectionString"].ConnectionString;
        }
        internal static string Save(RodSize aRodSize)
        {
            string query = "INSERT INTO t_rod_size(size) VALUES ('" + aRodSize.Size + "')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Rod size info saved";
            
        }

        public static RodSize IsSizeUnique(string size)
        {
            string query = "SELECT * FROM t_rod_size where size = '" + size + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                RodSize aRodSize = new RodSize();
                aRodSize.Size = sqlDataReader[1].ToString();
                sqlConnection.Close();
                return aRodSize;
            }
            sqlConnection.Close();
            return null;
        }



        public static List<RodSize> GetAll()
        {
            string query = "SELECT * FROM t_rod_size";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<RodSize> rodSizes = new List<RodSize>();

            while (sqlDataReader.Read())
            {
                RodSize aRodSize = new RodSize();
                aRodSize.Id = Convert.ToInt32(sqlDataReader[0]);
                aRodSize.Size = sqlDataReader[1].ToString();
                rodSizes.Add(aRodSize);
            }
            sqlConnection.Close();
            return rodSizes;
        }
    }
}

