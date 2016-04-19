using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SageOneSample.Controllers
{
    public class SudokuAPIController : ApiController
    {
        // GET: api/SudokuAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SudokuAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SudokuAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SudokuAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SudokuAPI/5
        public void Delete(int id)
        {
        }
    }
}
