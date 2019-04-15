using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{


    public class DAL
    {
        private SqlConnection conn = new SqlConnection();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlCommandBuilder builder = new SqlCommandBuilder();
        private SqlCommand command = new SqlCommand();

        //Constructor
        public DAL()
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            builder.DataAdapter = adapter;
        }

        private void Open()
        {
            conn.Open();
        }

        private void Close()
        {
            conn.Close();
        }

        public int InsertUpdateDelete(SqlCommand Command)
        {
            int affectedRows;
            //command = new SqlCommand(query, conn);
            command = Command;
            command.Connection = conn;
            Open();
            affectedRows = command.ExecuteNonQuery();
            Close();

            return affectedRows;
        }

        public DataTable GetTable(string query)
        {
            Open();
            adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Close();
            return table;
        }

        public void UpdateTable(DataTable table)
        {
            adapter.Update(table);
        }

    }
}
