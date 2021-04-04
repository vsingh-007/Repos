using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI01.Models;

namespace WebAPI01.Controllers
{
    public class ProductController : ApiController
    {
        static List<Product> _productList = null;

        void Initializer()
        {
            _productList = new List<Product>()
            {
                new Product() { ID = 1,Name = "Avast",QtyInStock = 100,Description = "Antivirus",Supplier = "Shubham" },
                new Product() { ID = 2,Name = "Trozen",QtyInStock = 300,Description = "Virus",Supplier = "Tarun" },
            };
        }

        public ProductController()
        {
            if(_productList==null)
            {
                Initializer();
            }
        }

        //Using IHttpActionResult
        public IHttpActionResult Get()
        {
            return Ok(_productList);
        }

        // GET: api/Product/5
        public IHttpActionResult Get(int id)
        {
            Product product = _productList.Where(x => x.ID == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }

        // POST: api/Product
        public IHttpActionResult Post(Product product)
        {
            if (product != null)
            {
                _productList.Add(product);
            }
            return Content(HttpStatusCode.Created, "Created");
        }

        // PUT: api/Product/5
        public IHttpActionResult Put(int id, Product objproduct)
        {
            Product product = _productList.Where(x => x.ID == id).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                if (product != null)
                {
                    foreach (Product temp in _productList)
                    {
                        if (temp.ID == id)
                        {
                            temp.Name = objproduct.Name;
                            temp.QtyInStock = objproduct.QtyInStock;
                            temp.Description = objproduct.Description;
                            temp.Supplier = objproduct.Supplier;
                        }
                    }
                }
                return Content(HttpStatusCode.OK, "Modified");
            }
        }

        // DELETE: api/Product/5
        public IHttpActionResult Delete(int id)
        {
            Product product = _productList.Where(x => x.ID == id).FirstOrDefault();

            if (product == null)
            {
                return NotFound();

            }
            else
            {
                if (product != null)
                {
                    _productList.Remove(product);
                }
                return Content(HttpStatusCode.OK, "Deleted");
            }

        }

        //
        // Using HttpResponseMessage

        //GET: api/Product


        //public HttpResponseMessage Get()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, _productList);
        //}

        //// GET: api/Product/5
        //public HttpResponseMessage Get(int id)
        //{
        //    Product product = _productList.Where(x => x.ID == id).FirstOrDefault();
        //    if (product == null)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Product not found");
        //    }
        //    else
        //    {
        //        return Request.CreateResponse(HttpStatusCode.OK, product);
        //    }
        //}

        //// POST: api/Product
        //public HttpResponseMessage Post(Product product)
        //{
        //    if (product != null)
        //    {
        //        _productList.Add(product);
        //    }
        //    return Request.CreateResponse(HttpStatusCode.Created);
        //}

        //// PUT: api/Product/5
        //public HttpResponseMessage Put(int id, Product objproduct)
        //{
        //    Product product = _productList.Where(x => x.ID == id).FirstOrDefault();

        //    if (product == null)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Product Not Found");
        //    }
        //    else
        //    {
        //        if (product != null)
        //        {
        //            foreach (Product temp in _productList)
        //            {
        //                if (temp.ID == id)
        //                {
        //                    temp.Name = objproduct.Name;
        //                    temp.QtyInStock = objproduct.QtyInStock;
        //                    temp.Description = objproduct.Description;
        //                    temp.Supplier = objproduct.Supplier;
        //                }
        //            }
        //        }
        //        return Request.CreateResponse(HttpStatusCode.OK, "Modified");
        //    }
        //}

        //// DELETE: api/Product/5
        //public HttpResponseMessage Delete(int id)
        //{
        //    Product product = _productList.Where(x => x.ID == id).FirstOrDefault();

        //    if (product == null)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Product Not found");

        //    }
        //    else
        //    {
        //        if (product != null)
        //        {
        //            _productList.Remove(product);
        //        }
        //        return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        //    }

        //}
    }
}
