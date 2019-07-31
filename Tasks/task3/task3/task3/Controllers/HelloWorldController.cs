using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace task3.Controllers
{
    [Produces("application/json")]
    [Route("api/HelloWorld")]
    public class HelloWorldController : Controller
    {
        // 
        // GET: HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}