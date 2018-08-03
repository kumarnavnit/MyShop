using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.WebUI
{
    public class DataConnection
    {
        public SqlConnection Con()
        {
            //string strcon1 = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;  
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["yourconnectinstringName"].ConnectionString);
            return Con();
            //create new sqlconnection and connection to database by using connection string from web.config file  
            // SqlConnection con = new SqlConnection();  
            //con.Open();


        }
        
    }
}