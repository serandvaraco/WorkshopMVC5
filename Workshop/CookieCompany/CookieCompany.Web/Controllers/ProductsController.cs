/*
    AUTOR:         SERGIO VARGAS 
    DESCRIPTION:   Permite mantener las peticiones HTTP 
                   y comunicación de vistas de los productos.  
 
 */

namespace CookieCompany.Web.Controllers
{
    using System.Web.Mvc;

    public class ProductsController : BaseController
    {

        // GET: Products
        public ActionResult Index()
        {
            return View(this.accessCatalog.GetProducts());
        }


        // TODO 1. Agregar las vistas requeridas para Agregar un nuevo Producto 

        // TODO 2. Agregar las vistas  requeridas para Eliminar un producto 

        // TODO 3. Agregar las vistas requeridas para Actualizar un producto 

        // TODO 4. Agregar las vistas requeridas para ver el detalle de un producto
    }
}