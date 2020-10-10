using Product.Models;
using Product.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Product.Controllers
{
    public class ProductController : ApiController
    {
        [HttpPost]
        [Authorize]
        [Route("api/Product/Create")]
        public string CreateProduct(ProductModels product)
        {
            DbHelper dbHelper = new DbHelper();
            product = dbHelper.CreateProduct(product);
            return "success";
        }


        [HttpDelete]
        [Authorize]
        [Route("api/Product/Delete/{id}")]
        public string DeleteProduct(ProductModels product)
        {
            DbHelper dbHelper = new DbHelper();
            product = dbHelper.DeleteProduct(product.Id);
            return "success";
        }

        [HttpGet]
        [Authorize]
        [Route("api/Product/GetAll")]
        public string GetAll(ProductModels product)
        {

            DbHelper dbHelper = new DbHelper();
            product = dbHelper.GetAllProduct();
            return "Success";

        }
    }
}
