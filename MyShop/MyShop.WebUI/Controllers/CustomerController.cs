using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyShop.Core.Models;
using MyShop.DataAccess.InMemory;


namespace MyShop.WebUI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            Customer customer = new Customer();
            return View(customer);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            
            string str1=System.Configuration.ConfigurationManager.ConnectionStrings["yourconnectinstringName"].ConnectionString;
            SqlConnection sc = new SqlConnection(str1); 
                sc.Open();           
            SqlCommand com = new SqlCommand("insert into tbl_customer(customerid,customername,customerdesc,customeraddress,cutomercategory) values('"+customer.Sid+"','"+customer.Name+"','"+customer.Description+"','"+customer.Address+"','"+customer.Description+"')", sc);
            com.Connection = sc;
                com.ExecuteNonQuery();
                return View(customer);
                
        }
        [HttpGet]
        public ActionResult Updatedata()
        {
            Customer customer = new Customer();
            return View(customer);
        }

        [HttpPost]
        public ActionResult UpdateData(Customer customer)

        {
             
                string str1 = System.Configuration.ConfigurationManager.ConnectionStrings["yourconnectinstringName"].ConnectionString;
                SqlConnection Con = new SqlConnection(str1);
                Con.Open();
                // con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
                //'"+customer.Sid+"','"+customer.Name+"','"+customer.Description+"','"+customer.Address+"','"+customer.Description+"'
                SqlCommand cmd = new SqlCommand("update tbl_customer set  customerdesc='" + customer.Description + "',customeraddress='" + customer.Address + "',cutomercategory='" + customer.Description + "' where customername='" + customer.Name + "'", Con);
            
                cmd.ExecuteNonQuery();
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@MobileID", MD.MobileID);

            //cmd.Parameters.AddWithValue("@MobileName", MD.MobileName);

            //cmd.Parameters.AddWithValue("@MobileIMEno", MD.MobileIMEno);

            //cmd.Parameters.AddWithValue("@mobileprice", MD.mobileprice);

            //cmd.Parameters.AddWithValue("@mobileManufacured", MD.mobileManufacured);

            //cmd.Parameters.AddWithValue("@Query", 2);

            //con.Open();
            //com

            ///  result = cmd.ExecuteScalar().ToString();

            //return result;
            return View(customer);
        }
        [HttpGet]
        public ActionResult DeleteRecord()
        {
            Customer customer = new Customer();
            return View(customer);
        }

       [HttpPost]
        public ActionResult DeleteRecord(Customer customer)
        {
            string str1 = System.Configuration.ConfigurationManager.ConnectionStrings["yourconnectinstringName"].ConnectionString;
            SqlConnection Con = new SqlConnection(str1);
            Con.Open();           
            SqlCommand cmd = new SqlCommand("delete from tbl_customer where customername='" + customer.Name + "'", Con);
            cmd.ExecuteNonQuery();
            return View(customer);
        }


        public ActionResult Edit()
        {
            Customer customer = new Customer();
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)

        {

            string str1 = System.Configuration.ConfigurationManager.ConnectionStrings["yourconnectinstringName"].ConnectionString;
            SqlConnection Con = new SqlConnection(str1);
            Con.Open();
            // con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ToString());
            //'"+customer.Sid+"','"+customer.Name+"','"+customer.Description+"','"+customer.Address+"','"+customer.Description+"'
            SqlCommand cmd = new SqlCommand("update tbl_customer set  customerdesc='" + customer.Description + "',customeraddress='" + customer.Address + "',cutomercategory='" + customer.Description + "' where customername='" + customer.Name + "'", Con);

            cmd.ExecuteNonQuery();
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@MobileID", MD.MobileID);

            //cmd.Parameters.AddWithValue("@MobileName", MD.MobileName);

            //cmd.Parameters.AddWithValue("@MobileIMEno", MD.MobileIMEno);

            //cmd.Parameters.AddWithValue("@mobileprice", MD.mobileprice);

            //cmd.Parameters.AddWithValue("@mobileManufacured", MD.mobileManufacured);

            //cmd.Parameters.AddWithValue("@Query", 2);

            //con.Open();
            //com

            ///  result = cmd.ExecuteScalar().ToString();

            //return result;
            return View(customer);
        }


    }
    }
