using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServices.Controllers
{
    public class UtilitiesController : ApiController
    {
        DataBussiness.SqlConn sql = new DataBussiness.SqlConn();
        
        // GET api/Connection
        public string Get()
        {
            sql.ConnectionTest();
            return "Database Connection established";
        }

    }
}
