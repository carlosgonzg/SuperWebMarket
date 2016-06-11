using super.web.market.bll;
using super.web.market.dal;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace super.web.market.api.Controllers
{
    [RoutePrefix("api/Auth")]
    public class AuthController : ApiController
    {
        private AuthHandler _authHandler = new AuthHandler();

        // GET: DOES NOTHING
        [Authorize]
        [Route("")]
        public async Task<IHttpActionResult> Get()
        {
            var user = _authHandler.GetActualUser();
            // var user = HttpContext.Current.GetOwinContext().Get<ApplicationUse>().
            var retData = new ReturnData(CodeStatus.Ok, "User extracted");
            retData.Data = user;
            return Ok(retData);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Register")]
        public async Task<IHttpActionResult> Register(User user)
        {
            HttpResponseMessage response = null;
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new Exception("Invalid Data");
                }
                User result = await _authHandler.Create(user);
                ReturnData retData = new ReturnData(CodeStatus.Ok, "Usuario creado exitosamente");
                retData.Data = result;
                response = Request.CreateResponse((HttpStatusCode)200, retData);
            }
            catch (Exception e)
            {
                response = Request.CreateResponse((HttpStatusCode)510, new ReturnData(CodeStatus.InvalidData, e.Message));
            }
            return new ResponseMessageResult(response);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _authHandler.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}