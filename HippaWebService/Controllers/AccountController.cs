using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using HippaWebService.Models;
using HippaWebService.Providers;
using HippaWebService.Results;

namespace HippaWebService.Controllers
{

    [RoutePrefix("situation")]
    public class StatusController:ApiController {
        [HttpGet]
        [Route("health")]
        public String healthCheck()
        {
            return "I AM ALIVE !!!!";
        }

    }
   
}
