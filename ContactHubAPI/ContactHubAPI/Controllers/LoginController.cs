using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactHubAPI.Models.User;

namespace ContactHubAPI.Controllers
{
    [RoutePrefix("api/anonymous")]
    public class LoginController : ApiController
    {
        [Route("signin")]
        [HttpPost]
        public IHttpActionResult UserSignin(LoginUserViewModel model)
        {
            return Ok(model);
        }

        [Route("signup")]
        [HttpPost]
        public HttpResponseMessage UserSignup(RegisterUser model)
        {
            return Request.CreateResponse(HttpStatusCode.OK,model);
        }
    }
}
