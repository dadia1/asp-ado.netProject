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
    public class AdminLogic
    {
        private DAL dal;

        public AdminLogic()
        {
            dal = new DAL();

        }

        public int UpdateVideos(VIdeos videos)
        {
            //string query = "UPDATE VIdeosTable SET Artist1 = ISNULL(" + (videos.Url_Vid1 == null ? "NULL" : "'" + videos.Url_Vid1 + "'") + " , Artist1)" +
            //    " , Artist2 = ISNULL(" + (videos.Url_Vid2 == null ? "NULL" : "'" + videos.Url_Vid2 + "'") + " , Artist2) , Artist3 = ISNULL(" + (videos.Url_Vid3 == null ? "NULL" : "'" + videos.Url_Vid3 + "'") + " , Artist3) " +
            //    " , Artist4 = ISNULL(" + (videos.Url_Vid4 == null ? "NULL" : "'" + videos.Url_Vid4 + "'") + " , Artist4) , Artist5 = ISNULL(" + (videos.Url_Vid5 == null ? "NULL" : "'" + videos.Url_Vid5 + "'") + " , Artist5) " +
            //    ", Artist6 = ISNULL(" + (videos.Url_Vid6 == null ? "NULL" : "'" + videos.Url_Vid6 + "'") + " , Artist6)";

            SqlCommand command = new SqlCommand();
            command.CommandText = "UpdateVid";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Art1", (object)videos.Url_Vid1 ?? DBNull.Value );
            command.Parameters.AddWithValue("@Art2", (object)videos.Url_Vid2 ?? DBNull.Value );
            command.Parameters.AddWithValue("@Art3", (object)videos.Url_Vid3 ?? DBNull.Value );
            command.Parameters.AddWithValue("@Art4", (object)videos.Url_Vid4 ?? DBNull.Value );
            command.Parameters.AddWithValue("@Art5", (object)videos.Url_Vid5 ?? DBNull.Value );
            command.Parameters.AddWithValue("@Art6", (object)videos.Url_Vid6 ?? DBNull.Value );

            return dal.InsertUpdateDelete(command);

            // int res = dal.InsertUpdateDelete(query);
            //return res;
        }
    }
}
