
/*
 AUTOR:         SERGIO VARGAS 
 DESCRIPTION:   Clase base de modelo 
 
 */

namespace CookieCompany.Model.Fluent
{
    using System;

    public class ModelBase
    {
        /// <summary>
        /// Permite generar un código unico para la entidad
        /// </summary>
        internal string GenerateIdCode => Guid.NewGuid().ToString(); 
    }
}
