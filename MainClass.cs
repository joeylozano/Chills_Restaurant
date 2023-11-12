using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Chills_Restaurant
{
    class MainClass
    {
        public static readonly string connectionString = "Server=tcp:chills-server.database.windows.net,1433;Initial Catalog=Chills_Restaurant;Persist Security Info=False;User ID=chilladmin;Password=Foxtrot@92;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static SqlConnection conn = new SqlConnection(connectionString);


        public static bool IsValidUser(string user, string passwords, string position)
        {
            bool isValid = false;

            string qry = @"SELECT * FROM users WHERE username ='"+user+ "' and upass ='" + passwords + "' and PositionID = '"+position+ "'  ";
            SqlCommand cmd = new SqlCommand(qry, conn);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0 ) 
            {
                isValid = true;
            }

            return isValid;
        }


        public static bool IsValidPIN(string pin, string name)
        {
            bool isValid = false;

            string qry = @"SELECT * FROM users WHERE PIN = '" +pin+ "' and username = '" +name+ "'  ";

            SqlCommand cmd = new SqlCommand(qry, conn);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                isValid = true;
            }

            return isValid;
        }

    }
}
