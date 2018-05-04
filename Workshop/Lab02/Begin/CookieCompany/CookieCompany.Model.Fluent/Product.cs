

/*
 AUTOR:         SERGIO VARGAS 
 DESCRIPTION:   Definición de Objeto producto
 
 */
namespace CookieCompany.Model.Fluent
{
    
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product : ModelBase
    {
        public Product()
        {
            Code = GenerateIdCode;
        }
        
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }


     

    }
    
}
