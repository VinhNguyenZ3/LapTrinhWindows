using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_NguyenTheVinh
{
    internal class KetNoi
    {
        String sqlConnect;
        public KetNoi()
        {
            sqlConnect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString();
        }
        public SqlConnection getConnect()
        {
            SqlConnection conn = new SqlConnection(sqlConnect);
            return conn;
        }
    }
}
