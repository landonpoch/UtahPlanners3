using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UtahPlanners.Application.Models;

namespace UtahPlanners.Application.Controllers
{
    [RoutePrefix("api/Property")]
    public class PropertyController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            var properties = new List<Property>
            {
                new Property { City = "Provo", Street = "Freedom Blvd." },
                new Property { City = "Orem", Street = "Center St." },
                new Property { City = "Springville", Street = "500 West" },
                new Property { City = "Sandy", Street = "Abbottsford Ln" },
            };
            return Ok(properties);
        }
    }
}
