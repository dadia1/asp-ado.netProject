using Commond.Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLogic
{
    public class UserBL
    {
        private DAL dal;
        User u;



        public UserBL()
        {
            dal = new DAL();
        }

        /// <summary>
        /// Register User and return success
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Register(User user)
        {

            //string query = string.Format("insert into users (first_name,last_name,email,phone,password,is_admin) " +
            //    "values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',0)",
            //            user.FirstName, user.LastName, user.Email, user.Phone, user.Password);

            SqlCommand command = new SqlCommand();
            command.CommandText = "InsertUser";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", user.UserId);
            command.Parameters.AddWithValue("@first_name", user.FirstName);
            command.Parameters.AddWithValue("@last_name", user.LastName);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@phone", user.Phone);
            command.Parameters.AddWithValue("@is_admin", user.IsAdmin);

            return dal.InsertUpdateDelete(command);
        }

        public DataTable CheckUser(User user)
        {
            string query = "SELECT email , password  FROM users " +
                "WHERE email ='" + user.Email + "' AND password ='" + user.Password + "'";

            DataTable res = dal.GetTable(query);
            return res;
        }

        public List<User> GetUsers()
        {
            string query = "select * from users";
            DataTable dt = dal.GetTable(query);

            List<User> users = new List<User>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    u = new User
                    {
                        FirstName = row["first_name"].ToString(),
                        LastName = row["last_name"].ToString(),
                        Email = row["email"].ToString(),
                        Phone = row["phone"].ToString(),
                        Password = row["password"].ToString(),
                    };
                    users.Add(u);
                }
            }
            return users;
        }
    }
}
