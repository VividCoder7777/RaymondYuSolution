using Microsoft.AspNetCore.Antiforgery;
using RaymondYuSolution.Controllers;

namespace RaymondYuSolution.Web.Host.Controllers
{
    public class AntiForgeryController : RaymondYuSolutionControllerBase
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
