using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace CoffeePsu.Controllers
{
    public class HomeController : BaseController
    {


        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok($"Ok, your id is {id}");
        }

        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            return Ok($"Ok, your name is {name}");
        }

    }
}
