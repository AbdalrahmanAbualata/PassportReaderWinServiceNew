using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using tutorial;

namespace PassportReaderWinService.Web_Api
{
    public class PassportApiController : ApiController
    { 
        [System.Web.Http.HttpGet]
        public HttpResponseMessage PassportTest()
        {

            try
            {
                MainClass prog = new MainClass();
                prog.Program();
            }
            catch (Pr22.Exceptions.General e)
            {
                System.Console.Error.WriteLine(e.Message);
            }
            //return 0;
        
            return Request.CreateResponse(HttpStatusCode.OK, "Passport Tested Successfuly", Configuration.Formatters.JsonFormatter);

        }
    }
}
