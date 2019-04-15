using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLogic
{
    public class MusicLogic
    {
        DAL dal = new DAL();

        //public void AddProduct(string productName, decimal unitPrice)
        //{
        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = "INSERT INTO Products(ProductName,UnitPrice) VALUES(@productName,@unitPrice)";
        //    command.Parameters.AddWithValue("@productName", productName);
        //    command.Parameters.AddWithValue("@unitPrice", unitPrice);
        //    Dal.InsertUpdateDelete(command);
        //}

        //public void UpdateProduct(int productID, string productName, decimal unitPrice)
        //{
        //    SqlCommand command = new SqlCommand();
        //    command.CommandText = "UpdateProduct";
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.AddWithValue("@productID", productID);
        //    command.Parameters.AddWithValue("@productName", productName);
        //    command.Parameters.AddWithValue("@unitPrice", unitPrice);
        //    Dal.InsertUpdateDelete(command);
        //}

        public DataTable GetString()
        {
            string query = "SELECT Msg FROM MsgHomePage ";
            return dal.GetTable(query);
        }

        public DataTable GetArtist()
        {

            string query = "SELECT * FROM VIdeosTable ";
            return dal.GetTable(query);
        }

        public DataTable GetSearch(string str)
        {
            string query = "SELECT Msg FROM MonthMsg Where( Msg like N'%" + str + "%' )";

            return dal.GetTable(query);
        }

        public DataTable GetContactUsName()
        {

            string query = "SELECT CompenyName FROM ContactUsTable ";
            return dal.GetTable(query);
        }
        public DataTable GetContactUsEmail()
        {

            string query = "SELECT Email FROM ContactUsTable ";
            return dal.GetTable(query);
        }
        public DataTable GetContactUsPhone()
        {

            string query = "SELECT Phone FROM ContactUsTable ";
            return dal.GetTable(query);
        }
    }
}
