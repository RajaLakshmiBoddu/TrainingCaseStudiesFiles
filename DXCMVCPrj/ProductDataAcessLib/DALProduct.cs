using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDataAcessLib
{
    public class DALProduct
    {
        public List<tbl_Category1> GetAllCategories()
        {
            DXCDBEntities dbctx = new DXCDBEntities();
            var result = dbctx.tbl_Category1.ToList();
            return result;
        }
        public List<tbl_Product> GetAllProducts()
        {
            DXCDBEntities dbctx = new DXCDBEntities();
            var result = dbctx.tbl_Product.ToList();
            return result;
        }
        public void AddProduct(tbl_Product pd)
        {
            DXCDBEntities dbctx = new DXCDBEntities();
            dbctx.tbl_Product.Add(pd);
            dbctx.SaveChanges();
        }
        public List<string> GetAllCategoryId()
        {
            DXCDBEntities dbctx = new DXCDBEntities();
            var result = dbctx.tbl_Category1.Select(o => o.categoryId).ToList();
            return result;
        }
        //public tbl_Category1 GetCatNameByCatId(string cid)
        //{
        //    DXCDBEntities dbctx = new DXCDBEntities();
        //    var result = dbctx.tbl_Category1.Select(o => o.categoryName);
        //    return (tbl_Category1)result;
        //}
        public string viewCategoryName(string cid)
        {
            DXCDBEntities dbctx = new DXCDBEntities();
            var result = dbctx.tbl_Category1.Where(o => o.categoryId == cid).Select(c => c.categoryName).SingleOrDefault();
            return result;
        }
        public tbl_Product ViewProducts(int id)
        {
            DXCDBEntities dbctx = new DXCDBEntities();
            var result = dbctx.tbl_Product.Where(p => p.ProductId == id).SingleOrDefault();
            return result;
        }
    }
}
