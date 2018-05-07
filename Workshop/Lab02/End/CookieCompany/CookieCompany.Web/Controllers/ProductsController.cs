/*
    AUTOR:         SERGIO VARGAS 
    DESCRIPTION:   Permite mantener las peticiones HTTP 
                   y comunicación de vistas de los productos.  
 
 */

namespace CookieCompany.Web.Controllers
{
    using CookieCompany.Model.Fluent;
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public class ProductsController : BaseController
    {

        // GET: Products
        public ActionResult Index()
        {
            return View(this.accessCatalog.GetProducts());
        }


        // TODO 1. Agregar las vistas requeridas para Agregar un nuevo Producto 
        [HttpGet]
        public ActionResult Create() => View();
        [HttpPost]
        public ActionResult Create(Product product)
        {
            #region Using FormCollections
            /*
             *  [0]: "__RequestVerificationToken"
                [1]: "Code"
                [2]: "Name"
                [3]: "Description"
                [4]: "State"
           

            var state = ((string[])product.GetValue("State").RawValue).First();

            var _product = new Product
            {
                Code = product.GetValue("Code").RawValue.ToString(),
                Name = product.GetValue("Name").RawValue.ToString(),
                Description = product.GetValue("Description").RawValue.ToString(),
                State = Convert.ToBoolean(state)
            };
            */
            #endregion
            var productName = product.Name.ToLower().Trim();
            if (accessCatalog.GetProducts()
                .Any(x => x.Name.ToLower() == productName))
            {
                ModelState.AddModelError("Name","Procuto Existente");
                return View(product);
            }


            accessCatalog.AddProduct(product);
            return RedirectToAction("Index");
        }
        // TODO 2. Agregar las vistas  requeridas para Eliminar un producto 
        [HttpGet]
        public ActionResult Delete(string code) => View(accessCatalog.GetProduct(code));

        public ActionResult Delete(Product product)
        {
            accessCatalog.DeleteProduct(product.Code);
            return RedirectToAction("Index");
        }

        // TODO 3. Agregar las vistas requeridas para Actualizar un producto 
        [HttpGet]
        public ActionResult Update(string code) => View(accessCatalog.GetProduct(code));
        [HttpPut]
        public ActionResult Update(Product product)
        {
            accessCatalog.UpdateProduct(product);
            return RedirectToAction("Index");
        }
        // TODO 4. Agregar las vistas requeridas para ver el detalle de un producto
        public ActionResult Details(string code) =>
            View(accessCatalog.GetProduct(code));

    }
}