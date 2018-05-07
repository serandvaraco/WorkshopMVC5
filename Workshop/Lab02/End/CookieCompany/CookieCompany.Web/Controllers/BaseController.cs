/*
 AUTOR:         SERGIO VARGAS 
 DESCRIPTION:   Clase base los controladores, 
                permite tener control de las peticiones asi como validadores de identidad
 
 */
namespace CookieCompany.Web.Controllers
{
    using CookieCompany.DomainCore.Manage;
    using System.Web.Mvc;
    using System.Web.Mvc.Filters;

    public class BaseController : Controller
    {
        #region ctor 
        public BaseController()
        {
            accessCatalog = new ManagementCore(); 
        }

        #endregion 
        #region Access Control
        protected override void OnAuthentication(AuthenticationContext filterContext)
        => base.OnAuthentication(filterContext);

        protected override void OnAuthorization(AuthorizationContext filterContext)
        => base.OnAuthorization(filterContext);

        #endregion

        #region Access BI
        internal readonly IAccessCatalog accessCatalog; 

        #endregion
    }
}