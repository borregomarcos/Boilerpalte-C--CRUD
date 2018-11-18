using Microsoft.AspNetCore.Antiforgery;
using boilerplate.Controllers;

namespace boilerplate.Web.Host.Controllers
{
    public class AntiForgeryController : boilerplateControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
