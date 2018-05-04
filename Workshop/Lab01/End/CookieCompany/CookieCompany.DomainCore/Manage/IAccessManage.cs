/*
    AUTOR:         SERGIO VARGAS 
    DESCRIPTION:   Pemrite la ejecución controlada por contratos
 
 */
namespace CookieCompany.DomainCore.Manage
{
    using CookieCompany.Model.Fluent;
    using System.Collections.Generic;


    public interface IAccessCatalog
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(string code);
        IEnumerable<Product> GetProducts(bool state);

        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(string code);
    }
}
