using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductDataAcessLib;

namespace ProductMVCWebApplication.Controllers
{
    public class UIController : Controller
    {
        // GET: UI
       [HttpGet]
        public ActionResult Index()
        {
            //DALProduct dal = new DALProduct();
            //var catId = dal.GetAllCategoryId().ToList();
            //ViewData.Add("catId", catId);
            return View();
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            DALProduct dal = new DALProduct();
            var catId = dal.GetAllCategoryId().ToList();
            ViewData.Add("categoryId", catId);
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(tbl_Product pd)
        {
            DALProduct dal = new DALProduct();
            dal.AddProduct(pd);
            var catId = dal.GetAllCategoryId().ToList();
            ViewData.Add("categoryId", catId);
            ViewData.Add("Message", "product record Added");
            //RedirectToAction("ViewCategoryName");
            return View();
        }
        [HttpGet]
        public ActionResult GetAllProducts()
        {
            DALProduct dal = new DALProduct();
            List<tbl_Product> lst = dal.GetAllProducts();
            //RedirectToAction("ViewCategoryName");
            return View(lst);
        }
        [HttpGet]
        public ActionResult ViewCategoryName(int id,string cid)
        {
            DALProduct dal = new DALProduct();
            var record = dal.ViewProducts(id);
            var catName = dal.viewCategoryName(cid);
            ViewData.Add("categoryName", catName);
            return View(record);
        }
    }
}