using AutoMapper;
using Car_store_theme.Data;
using Car_store_theme.Entity;
using Car_store_theme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_store_theme.Repository
{
    public class ProductRepository : 
    {
        private readonly IDataFactory _dataFactory;
        private DataFactoryDataContext _dataDataContext;
        public ProductRepository(IDataFactory dataFactory)
        {
            _dataFactory = dataFactory;
            _dataDataContext = dataFactory.GetDataFactoryDataContext();
        }
        public List<Product> Getproducts()
        {
            var product = _dataDataContext.Getproductdata20220906().ToList();

            var productDetail = (from p in product
                                 select new Product
                                 {
                                     Id = p.Id,
                                     ProductName = p.ProductName,
                                     Image = p.Image,
                                     Price = (decimal)p.Price,
                                     Rating = (decimal)p.Rating,
                                     Cartbtn = p.Cartbtn,
                                     HoverImage = p.HoverImage,
                                     IndicatorImage = p.IndicatorImage,
                                     Short_Description = p.Short_Description,
                                     Description = p.Description
                                 }).ToList();
            return productDetail;

        }

        public List<Product> GetProductcategory(Product productData)
        {

            var productctg = _dataDataContext.GetCategory20220907().ToList();

            var categoryDetail = (from p in productctg
                                  select new Product
                                  {
                                      categoriesName = p.categoriesName,
                                      ClothingItem = p.ClothingItem,
                                      VehicleBracelets = p.VehicleBracelets,
                                      VehicleRings = p.VehicleRings,
                                      Shoes = p.Shoes,
                                      Lingeries = p.Lingeries
                                  }).ToList();
            return categoryDetail;

        }

        public List<Product> GetFilters(string filterData)
        {
            var productflt = _dataDataContext.SortProductByPrice_20220907(filterData).ToList();
            var productfilter = (from p in productflt
                                 select new Product
                                 {
                                     Id = p.Id,
                                     ProductName = p.ProductName,
                                     Image = p.Image,
                                     Price = (decimal)p.Price,
                                     Rating = (decimal)p.Rating,
                                     Cartbtn = p.Cartbtn,
                                     HoverImage = p.HoverImage,


                                 }).ToList();

            return productfilter;
        }

        public ProductModel GetProductById(int Id)
        {
            var PDPId = _dataDataContext.GetPDPId20220912(Id).SingleOrDefault();
            var PDPDataId = Mapper.Map<GetPDPId20220912Result, ProductModel>(PDPId);
            return PDPDataId;
        }
    }
}