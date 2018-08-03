using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using MyShop.Core.Models;
using MyShop.DataAccess.InMemory;
namespace MyShop.WebUI.Controllers
{
    public class Department_ContController : Controller
    {
        // GET: Department_Cont
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            Department dept = new Department();
            return View(dept);
        }
        [HttpPost]
        public ActionResult Create(Department dept)
        {

            string str1 = System.Configuration.ConfigurationManager.ConnectionStrings["yourconnectinstringName"].ConnectionString;
            SqlConnection sc = new SqlConnection(str1);
            sc.Open();
            SqlCommand com = new SqlCommand("insert into Detartment(name,InchargeName) values('" + dept.name + "','" + dept.InchargeName + "')", sc);
            com.Connection = sc;
            com.ExecuteNonQuery();
            return View(dept);

        }

    }
}