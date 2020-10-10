using Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;

namespace Product.Repository
{
    public class DbHelper
    {
        public ProductModels CreateProduct(ProductModels product)
        {
            using (var dbEntities = new ProductContext())
            {
                var productObj = new ProductModels()
                {
                    //ID is auto generate
                    Name = product.Name,
                    Price = product.Price,
                    description = product.description
                };
                dbEntities.ProductModels.Add(productObj);
                dbEntities.SaveChanges();
                product.Id = productObj.Id;
            }
            return product;
        }

        public ProductModels DeleteProduct(int id)
        {
            using (var dbEntities = new ProductContext())
            {
                var productObj = dbEntities.ProductModels.SingleOrDefault(e => e.Id == id);
                dbEntities.ProductModels.Remove(productObj);
                dbEntities.SaveChanges();
            }
            return null;
        }


        public ProductModels GetAllProduct()
        {
            var dbEntities = new ProductContext();
            var productObj = dbEntities.ProductModels.ToList();

            return null;
        }

    }
}