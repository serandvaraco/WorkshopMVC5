

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

        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre de producto")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        [DataType(DataType.MultilineText)]
        [MaxLength(300)]
        public string Description { get; set; }

        [Display(Name = "Estado")]
        public bool State { get; set; }




    }

}
