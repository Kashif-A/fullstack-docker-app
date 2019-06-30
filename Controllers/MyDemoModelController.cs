using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace My.Namespace.Controllers
{
    [Route("api/[controller]")]
   // [ApiController]
    public class MyDemoModelController : ControllerBase
    {
        public String hello(){
            return "hello";
        }
    }
}