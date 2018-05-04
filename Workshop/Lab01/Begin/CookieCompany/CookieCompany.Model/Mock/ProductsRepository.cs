using CookieCompany.Model.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCompany.Model.Mock
{
    public class ProductsRepository
    {
        private static Lazy<ICollection<Product>> lazy = new Lazy<ICollection<Product>>(() =>
        {
            return new Product[] {
                new Product{ Name= "Galleta Maria",Description="galleta redonda tradicional en España y algunos países de América Latina." , State=true },
                new Product{ Name= "Galleta Rellena",Description="están hechos de una masa de galletas llenado con un relleno de fruta o de confitería antes de hornear." , State=true },
                new Product{ Name= "Oblea",Description="galleta fina con una o varias capas de relleno, también llamada wafer." , State=true },
                new Product{ Name= "Cookie",Description=" (termino anglosajón para referirse a la galleta): la chocolate chip cookie con virutas de chocolate, muy común en EEUU." , State=true },
                new Product{ Name= "Pretzel",Description="tipo de galleta, tradicionalmente salada, con forma de nudo." , State=true },
            };
        });

        public static ICollection<Product> Products => lazy.Value;
    }
}
