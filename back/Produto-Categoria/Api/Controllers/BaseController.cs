using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T,R> : ControllerBase where T :Base where R:BaseRepository<T>
    {
        R repository = Activator.CreateInstance<R>();
        // GET: api/<BaseController>
        [HttpGet]
        public IEnumerable<T> Get()
        {
            return repository.Read();
        }

        // GET api/<BaseController>/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return repository.Read(id);
        }

        // POST api/<BaseController>
        [HttpPost]
        public void Post([FromBody] T model)
        {
            repository.Create(model);
        }

        // PUT api/<BaseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] T model)
        {
            repository.Update(model);
        }

        // DELETE api/<BaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
