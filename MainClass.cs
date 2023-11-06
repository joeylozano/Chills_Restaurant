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
        public static readonly string connectionString = "Data Source=LAPTOP-U9V72D48\\SQLEXPRESS01;Initial Catalog=Chills_Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
