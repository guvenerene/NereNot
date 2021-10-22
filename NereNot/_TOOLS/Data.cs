using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NereNot._TOOLS
{
    class Data
    {
        public static DataTable dataTable(string connectString, string commend)
        {
            DataTable dataTable = new DataTable();

            SqlConnection sqlConnection = new SqlConnection(connectString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commend, sqlConnection);

            dataAdapter.SelectCommand.CommandTimeout = 0;

            if (sqlConnection.State == ConnectionState.Closed)
                //con.Open();

                try
                {
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    commend = "";
                }
                catch (Exception ex)
                {
                    commend = ex.Message;
                    dataTable = null;
                }
                finally { sqlConnection.Close(); dataAdapter.Dispose(); }

            return dataTable;


        }
    }
}
