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
    public class RodQualityDataAccess
    {
        private static string connectionString = null;

        public RodQualityDataAccess()
        {
            connectionString =
                ConfigurationManager.ConnectionStrings["InventoryManagementDbConectionString"].ConnectionString;
        }
        internal string Save(RodQuality aRodQuality)
        {
            string query = "INSERT INTO t_rod_quality(quality) VALUES ('" + aRodQuality.Quality + "')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "Rod Quality info saved";
            
        }

        public object IsQualityUnique(string quality)
        {
            string query = "SELECT * FROM t_rod_quality where quality = '" + quality + "'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                RodQuality aRodQuality = new RodQuality();
                aRodQuality.Quality = sqlDataReader[1].ToString();
                sqlConnection.Close();
                return aRodQuality;
            }
            sqlConnection.Close();
            return null;
        }

        public List<RodQuality> GetAll()
        {
            string query = "SELECT * FROM t_rod_quality";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<RodQuality> rodQualities = new List<RodQuality>();

            while (sqlDataReader.Read())
            {
                RodQuality aRodQuality = new RodQuality();
                aRodQuality.Id = Convert.ToInt32(sqlDataReader[0]);
                aRodQuality.Quality = sqlDataReader[1].ToString();
                rodQualities.Add(aRodQuality);
            }
            sqlConnection.Close();
            return rodQualities;
        }
    }
}
