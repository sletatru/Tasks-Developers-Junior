using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Task_web.Models;

namespace Task_web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private List<TestModel> _testModels;
        /*
        public TestController()
        {
            _testModels = new List<TestModel>();
            var testModel = new TestModel();
            testModel.Id = 1;
            testModel.Identifier = new Guid();
            testModel.Name = "name";
            _testModels.Add(testModel);

        }
        */
        
        public TestController(List<TestModel> testModels)
        {
            _testModels = testModels;
        }
        

        //необходимо релизовать CRUD для testModels
        // GET api/test
        [HttpGet]
        public ActionResult<List<TestModel>> Get()
        {
            // var testModels = new List<TestModel>();
            // var result = new ActionResult<IList<TestModel>>(_testModels);
            // return result;

            return _testModels;
        }

        // GET: api/test/5
        [HttpGet("{id}")]
        public ActionResult<TestModel> Get(long id)
        {
            /*for list() {
                if (iterator.id = id{
                    retuyrn ite;s
                }
            }

            retrun NotFoutnd*/

            var testModel = new TestModel();
            testModel.Id = id;
            testModel.Name = "ann";
            if (testModel == null)
            {
                return NotFound();
            }

            return testModel;
        }
        // POST api/test
        [HttpPost]
        public void Post([FromBody] TestModel item)
        {
            /*_testModels = new List<TestModel>();
            var testModel = new TestModel();
            testModel.Id = 1;
            testModel.Identifier = new Guid();
            testModel.Name = "name";
            _testModels.Add(testModel);
            return _testModels;*/
            int a = 1;
            //add
        }

        // PUT api/test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TestModel item)
        {
            int a = 0;
        }

        // DELETE api/test/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            int a = 2;
        }
    }
}
