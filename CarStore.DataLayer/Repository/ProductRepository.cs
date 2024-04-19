
using Car_store_theme.Data;
using Car_store_theme.Entity;
using CarStore.DataLayer.DBML;
using CarStore.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.DataLayer.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataFactory _dataFactory;
        private DataFactoryDataContext _dataDataContext;
        public ProductRepository(IDataFactory dataFactory)
        {
            _dataFactory = dataFactory;
            _dataDataContext = dataFactory.GetDataFactoryDataContext();
        }
       

        public List<Car_store_theme.Entity.Product> GetProductcategory(Car_store_theme.Entity.Product productData)
        {

            var productctg = _dataDataContext.procGetCategory().ToList();

            var categoryDetail = (from p in productctg
                                  select new Car_store_theme.Entity.Product
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

        public List<Car_store_theme.Entity.Product> GetFilters(string filterData)
        {
            var productflt = _dataDataContext.procSortProduct(filterData).ToList();
            var productfilter = (from p in productflt
                                 select new Car_store_theme.Entity.Product
                                 {
                                     ProductId = p.ProductId,
                                     ProductName = p.ProductName,
                                     Image = p.Image,
                                     Price = (decimal)p.Price,
                                     Rating = (int)p.Rating,
                                     HoverImage = p.HoverImage,


                                 }).ToList();

            return productfilter;
        }

      public Car_store_theme.Entity.Product GetProductById(Guid ProductId)
        {
            var PDPId = _dataDataContext.procGetProductId(ProductId);
           var PDPDataId = (from p in PDPId
                            select new Car_store_theme.Entity.Product
                            {
                                ProductId = p.ProductId,
                                ProductName = p.ProductName,
                                Image = p.Image,
                                Price = (decimal)p.Price,
                                Rating = (int)p.Rating,
                                HoverImage = p.HoverImage,
                                IndicatorImage = p.IndicatorImage,            
                            }).SingleOrDefault();
           return PDPDataId;
      }

        public List<Car_store_theme.Entity.Product> Getproducts()
        {
            var product = _dataDataContext.procGetProducts().ToList();

            var productDetail = (from p in product
                                 select new Car_store_theme.Entity.Product
                                 {
                                     ProductId = p.ProductId,
                                     ProductName = p.ProductName,
                                     Image = p.Image,
                                     Price = (decimal)p.Price,
                                     Rating = (int)p.Rating,
                                     HoverImage = p.HoverImage,
                                     IndicatorImage = p.IndicatorImage,
                                     ShortDescription = p.Short_Description,
                                     Description = p.Description
                                 }).ToList();
            return productDetail;

        }


        public BoolResponse UploadProducts(Car_store_theme.Entity.Product upldProducts)
        {
       var contextResponse =_dataDataContext.procUpsertProduct(upldProducts.ProductId, upldProducts.ProductName, upldProducts.Categories, upldProducts.Image,
                upldProducts.Price, upldProducts.Rating, upldProducts.HoverImage, upldProducts.IndicatorImage,
                upldProducts.Description, upldProducts.ShortDescription);

       var response = (from o in contextResponse
                            select new BoolResponse
                            {
                                IsValid=o.IsValid.GetValueOrDefault(),
                                Message=o.Message,
                            }
                          ).SingleOrDefault();
            return response;
        }

        public List<Car_store_theme.Entity.Product> DeleteProducts(Guid ProductDelete)
        {
           _dataDataContext.procDeleteProduct(ProductDelete);          
            return null;
        }
    }
}