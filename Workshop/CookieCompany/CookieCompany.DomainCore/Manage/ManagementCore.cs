
namespace CookieCompany.DomainCore.Manage
{
    using CookieCompany.Model.Fluent;
    using CookieCompany.Model.Mock;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;


    public class ManagementCore : IAccessCatalog
    {
        private ICollection<Product> Products
        {
            get
            {
                if (HttpContext.Current.Cache["__products"] == null)
                    HttpContext.Current.Cache["__products"] = ProductsRepository.Products;

                return HttpContext.Current.Cache["__products"] as ICollection<Product>;
            }

            set
            {

                if (HttpContext.Current.Cache["__products"] == null)
                    HttpContext.Current.Cache["__products"] = ProductsRepository.Products;

                var products = ((ICollection<Product>)HttpContext.Current.Cache["__products"]);
                products = value;
            }
        }



        void IAccessCatalog.AddProduct(Product product)
         => Products.Add(product);

        void IAccessCatalog.DeleteProduct(string code)
        {
            var product = Products.FirstOrDefault(x => x.Code == code);
            if (product != null)
                Products.Remove(product);
        }

        Product IAccessCatalog.GetProduct(string code)
            => Products.FirstOrDefault(x => x.Code == code);


        IEnumerable<Product> IAccessCatalog.GetProducts() => Products;

        IEnumerable<Product> IAccessCatalog.GetProducts(bool state)
        => Products.Where(x => x.State == state);

        void IAccessCatalog.UpdateProduct(Product product)
        {
            var _product = Products.FirstOrDefault(x => x.Code == product.Code);
            if (_product == null) return;

            _product.Name = product.Name;
            _product.Description = product.Description;
            _product.State = product.State;

        }
    }
}
