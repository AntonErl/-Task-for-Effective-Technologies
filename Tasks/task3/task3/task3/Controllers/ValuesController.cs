using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
 

namespace task3.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string [] { "web-api вычисляющее MD5-hash. Хэш от строки по запрсу api/ReadString/WritteString. На месте WritteString напишите нужную строку. Хэш от файла по запросу api/ReadFile  "};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

 
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
