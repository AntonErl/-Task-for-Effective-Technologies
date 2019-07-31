using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Cryptography;

namespace task3.Controllers
{
    [Produces("application/json")]
    [Route("api/ReadFile")]
    public class ReadFileController : Controller
    {

        static string CalculateMD5(string filename)
        {
            MD5 md5 = MD5.Create();
            FileStream stream = new FileStream(filename, FileMode.Open);
            var hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }

        // GET: api/ReadFile
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "web-api вычисл€ющее MD5-hash от файла." };
        }

        // GET: api/ReadFile/5
        [HttpGet("{id}")]
        public string Get(String id)
        {
            string FileMD5 = CalculateMD5(@"E:\text.txt");
            //string FileMD5 = CalculateMD5(id);
            string resultAll = "MD5 hash from a file: " + id + " = " + FileMD5;
            return resultAll;
        }
        
        // POST: api/ReadFile
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/ReadFile/5
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
