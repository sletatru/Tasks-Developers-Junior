using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_web.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Task_web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private List<TestModel> _testModels;

        public TestController(List<TestModel> testModels)
        {
            _testModels = testModels; 
        }
        
        //необходимо релизовать CRUD для testModels
        // GET api/test
        [HttpGet]
        public ActionResult<List<TestModel>> Get()
        {
            return _testModels;
        }

        // GET: api/test/5
        [HttpGet("{id}")]
        public ActionResult<TestModel> Get(long id)
        {
            foreach(TestModel item in _testModels)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return NotFound();
        }

        // POST api/test
        [HttpPost]
        public ActionResult<TestModel> Post([FromBody] TestModel testModel)
        {
            _testModels.Add(testModel);
            return CreatedAtAction(nameof(Get), new { id = testModel.Id }, testModel);
        }

        // PUT api/test/5
        [HttpPut("{id}")]
        public ActionResult<TestModel> Put(long id, [FromBody] TestModel testModel)
        {
            bool changed = false;
            foreach(TestModel item in _testModels)
            {
                if (id == item.Id)
                {
                    changed = true;
                    if (testModel.Name != null)
                    {
                        item.Name = testModel.Name;
                    }
                    if (testModel.Identifier != null)
                    {
                        item.Identifier = testModel.Identifier;
                    }
                }                
            }
            if (changed == false) {
                return BadRequest();
            }             
            return NoContent();
        }

        // DELETE api/test/5
        [HttpDelete("{id}")]
        public ActionResult<HttpStatusCode> Delete(long id)
        {
            foreach(TestModel item in _testModels)
            {
                if (id == item.Id)
                {
                    _testModels.Remove(item);
                    return NoContent();
                }
            }
            return NotFound();
        }
    }
}
