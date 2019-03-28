using Microsoft.AspNetCore.Antiforgery;
using Shertech001.Controllers;

namespace Shertech001.Web.Host.Controllers
{
    public class AntiForgeryController : Shertech001ControllerBase
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
