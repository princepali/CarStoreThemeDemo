using AutoMapper;
using Car_store_theme.Entity;
using Car_store_theme.Models;
using Car_store_theme.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_store_theme.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _ProductService;
        public ProductController(IProductService ProductService)
        {
            _ProductService = ProductService;
        }

        /*  public ActionResult Index()
          {
              return View();  
          }*/

        // GET: Product
        public ActionResult ProductList()
        {
            return View();
        }

        public ActionResult ProductDetail(Guid Id)
        {
            var PdpData = _ProductService.GetProductById(Id);
            var productDetail = Mapper.Map<Product, ProductModel>(PdpData);
            return View(productDetail);
        }

        public ActionResult Basket()
        {
            return View();
        }

        public ActionResult UploadProductList()
        {
            return View();
        }

        public ActionResult WishList()
        {
            return View();
        }




    [HttpGet]
        public JsonResult GetProducts(Entity.Product productData)
        {
            var productInfo = _ProductService.Getproducts(productData);

            var productDetail = Mapper.Map<List<Entity.Product>, List<ProductModel>>(productInfo);


            return Json(productDetail, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult Getcategory(Entity.Product productData)
        {
            var productInfo = _ProductService.GetProductcategory(productData);

            var productCategory = Mapper.Map<List<Entity.Product>, List<CategoryModel>>(productInfo);


            return Json(productCategory, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult GetFilters(string SortCriteria)
        {

            var productInfo = _ProductService.GetFilters(SortCriteria);
            var productFilter = Mapper.Map<List<Entity.Product>, List<ProductModel>>(productInfo);
            return Json(productFilter, JsonRequestBehavior.AllowGet);
        }




        public JsonResult UploadProducts(Entity.Product ProductDetails)
        {
            string path = Server.MapPath("~/Images/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            foreach (string key in Request.Files)
            {
                HttpPostedFileBase postedFile = Request.Files[key];
                if (postedFile != null && postedFile.ContentLength > 0)
                {
                    // Generate a unique file name to prevent overwriting existing files
                    string fileName = Path.GetFileName(postedFile.FileName);
                    string filePath = Path.Combine(path, fileName);

                    // Save the file
                    postedFile.SaveAs(filePath);
                    ProductDetails.Image = "/images/"+fileName;
                    //string constr = ConfigurationManager.ConnectionStrings["carStoreDBConnectionString"].ConnectionString;
                    //using (SqlConnection con = new SqlConnection(constr))
                    //{
                    //    string query = "INSERT INTO tblFilesPath VALUES (@Name,@Path)";
                    //    using (SqlCommand cmd = new SqlCommand(query))
                    //    {
                    //        cmd.Connection = con;
                    //        cmd.Parameters.AddWithValue("@Name", postedFile.FileName);
                    //        cmd.Parameters.AddWithValue("@Path", "~/Uploads/" + postedFile.FileName);
                    //        con.Open();
                    //        cmd.ExecuteNonQuery();
                    //        con.Close();
                    //    }
                    //}
                }
            }
            var boolResponse = _ProductService.UploadProducts(ProductDetails);
            //var response=Mapper.Map<Product>(Product);
            return Json(boolResponse, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteProducts(Guid ProductDelete)
        {
            var deleteproductid= _ProductService.DeleteProducts(ProductDelete);
            return Json(deleteproductid,JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult AddToCart(string Name)
        {
            var addtocartcookie = Request.Cookies[Name];
            if (addtocartcookie != null)
            {
                var productIds = addtocartcookie.Value.Split('-').Select(x => Guid.Parse(x)).ToList();
                var product = _ProductService.GetProductCart(productIds);
                return Json(product, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }


        }
    }
}