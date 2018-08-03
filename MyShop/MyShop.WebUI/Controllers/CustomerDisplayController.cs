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
    public class CustomerDisplayController : Controller
    {
        // GET: CustomerDisplay
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //    [HttpGet]
        //    public ActionResult CDetails()
        //    {
        //        Cus_Display customerD = new Cus_Display();
        //        return View(customerD);
        //    }
        //    [HttpPost]
        //    public ActionResult CDetails(Cus_Display customerD)
        //    {
        //        string str1 = System.Configuration.ConfigurationManager.ConnectionStrings["yourconnectinstringName"].ConnectionString;
        //        SqlConnection sc = new SqlConnection(str1);
        //        // return Con();
        //        //DataConnection dc = new DataConnection();
        //        //    SqlConnection sc = dc.Con();
        //        sc.Open();
        //        String sql = "SELECT * FROM tbl_customer";
        //        SqlCommand cmd = new SqlCommand(sql, sc);

        //        var model = new List<Cus_Display>();
        //        using (SqlConnection conn = new SqlConnection(str1))
        //        {
        //            conn.Open();
        //            SqlDataReader rdr = cmd.ExecuteReader();
        //            while (rdr.Read())
        //            {
        //                //var customer = new Customer();
        //                customerD.Sid = rdr["customerid"].ToString();
        //                customerD.Name = rdr["customername"].ToString();
        //                customerD.Description = rdr["customerdesc"].ToString();
        //                customerD.Address = rdr["customeraddress"].ToString();
        //                customerD.Category = rdr["cutomercategory"].ToString();
        //                //model.Add(customer);
        //                //model.Add(customerD);
        //                model.Add(customerD);
        //            }

        //        }

        //        return View(model);
        //    }




        //string str1 = System.Configuration.ConfigurationManager.ConnectionStrings["yourconnectinstringName"].ConnectionString;
        //        SqlConnection sc = new SqlConnection(str1);
        //        // return Con();
        //        //DataConnection dc = new DataConnection();
        //        //    SqlConnection sc = dc.Con();
        //        sc.Open();


        private List<Cus_Display> Cus = new List<Cus_Display>();

        private int _nextId = 1;

        SqlConnection con;

        SqlDataAdapter da;

        DataSet ds = new DataSet();



        public ActionResult Index()

        {

            //con = new SqlConnection("Data Source=MYPC;Initial Catalog=MyDb;uid=sa;pwd=wintellect");
            string str1 = System.Configuration.ConfigurationManager.ConnectionStrings["yourconnectinstringName"].ConnectionString;
            SqlConnection con = new SqlConnection(str1);
            da = new SqlDataAdapter("select * from tbl_customer", con);

            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)

            {

                Cus.Add(new Cus_Display() { Sid = dr[0].ToString(), Name = dr[1].ToString(), Description = dr[2].ToString(), Address = dr[3].ToString(),Category=dr[4].ToString() });

            }

            return View(Cus);

        }



        public Cus_Display Find(string Id)
        {
            Cus_Display customer1 = Cus.Find(c => c.id == Id);

            if (customer1 != null)
            {
                return customer1;
            }
            else
            {
                throw new Exception("Product Not Editable");
            }
        }
        public IQueryable<Cus_Display> Collection()
        {
            

            return Cus.AsQueryable();
        }
        public void Delete(string id)
        {
            Cus_Display CustomerToDelete = Cus.Find(p => p.Sid == id);
            if (CustomerToDelete != null)
            {
                CustomerToDelete.Remove(CustomerToDelete);
            }
            else
            {
                throw new Exception("Product Not Found");
            }
        }
        
        //public void Update(Cus_Display CustUpdate)
        //{
        //    Cus_Display CustToUpdate = CustUpdate.Find(c =>c.id==CustUpdate.id);//Find(c=> c.id == CustUpdate.id);
        //    if (CustToUpdate != null)
        //    {
        //        CustToUpdate = CustUpdate;
        //    }
        //    else
        //    {
        //        throw new Exception("Product Not Found");
        //    }
        //}


    }

}

   