using System;
using System.Data;
using System.Data.SqlClient;

namespace Mainstream_Anime_Emporium
{
    public class dbTransactions
    {
        private bool _manager = false;

        public bool Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }

        public bool custLogIn(string un, string pw)
        {
            string connectS = "Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787";
            SqlConnection con = new SqlConnection(connectS);
            SqlCommand com = new SqlCommand("Select customerID From cpswanson.customers Where username Like @un And password Like @pw", con);
            com.Parameters.AddWithValue("@un", un);
            com.Parameters.AddWithValue("@pw", pw);

            if(com.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool empLogIn(string un, string pw)
        {
            string connectS = "Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787";
            SqlConnection con = new SqlConnection(connectS);
            SqlCommand com = new SqlCommand("Select employeeID From cpswanson.employees Where username Like @un And password Like @pw", con);
            com.Parameters.AddWithValue("@un", un);
            com.Parameters.AddWithValue("@pw", pw);

            if (com.ExecuteNonQuery() == 1)
            {
                com = new SqlCommand("Select managerID From cpswanson.employees Where username Like @un And password Like @pw", con);
                com.Parameters.AddWithValue("@un", un);
                com.Parameters.AddWithValue("@pw", pw);
                if(com.ExecuteNonQuery() == 0)
                {
                    Manager = true;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public string newOrder()
        {
            return "";
        }
    }
}
