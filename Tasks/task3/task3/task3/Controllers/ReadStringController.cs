using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Cryptography;

namespace task3.Controllers
{
    [Produces("application/json")]
    [Route("api/ReadString")]
    public class ReadStringController : Controller
    {

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            //return Convert.ToBase64String(hash);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
        // GET: api/ReadString
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "web-api вычисл€ющее MD5-hash от строки." };
        }

        // GET: api/ReadString/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            string resultMD5 = GetHash(id);
            string resultAll = "MD5 hash from a string: " + id + " = " + resultMD5;
            return resultAll;
        }
        
        // POST: api/ReadString
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/ReadString/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
