using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timec_lock.DAL
{
    public class DBContext

    {
        private readonly string _connectionString;
        //Data Source=DESKTOP-F6TEN9G;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        public DBContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DataTable MakeQewry(string qweryStr)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(qweryStr, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("an error occurred: " + ex.Message);
                    }
                }
            }

            return output;

        }

    }
}
