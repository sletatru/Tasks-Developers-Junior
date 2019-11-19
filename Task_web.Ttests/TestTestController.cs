using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Task_web.Controllers;
using Task_web.Models;

namespace Task_web.Tests
{
    [TestClass]
    public class TestControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            TestController controller = new TestController(new List<TestModel>());
            // Act
            ActionResult < List < TestModel >> result = controller.Get();
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetReturnsFound()
        {
            // Arrange
            TestModel testModel = new TestModel();
            testModel.Id = 10;
            testModel.Name = "MyName";
            testModel.Identifier = new Guid("00000000-0000-0000-0000-000000000001");
            var testModels = new List<TestModel>();
            testModels.Add(testModel);
            TestController controller = new TestController(testModels);
            // Act
            ActionResult<TestModel> result = controller.Get(testModel.Id);
            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Value);
            Assert.IsTrue(result.Value.Id == testModel.Id);
            Assert.IsTrue(result.Value.Name == testModel.Name);
            Assert.IsNull(result.Result);
        }

        [TestMethod]
        public void GetReturnsNotFound()
        {
            // Arrange
            TestController controller = new TestController(new List<TestModel>());
            // Act
            ActionResult<TestModel> result = controller.Get(1);
            // Assert
            Assert.IsNotNull(result);
            Assert.IsNull(result.Value);
            Assert.IsInstanceOfType(result.Result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void PostMethodSetsLocationHeader()
        {
            // Arrange
            TestController controller = new TestController(new List<TestModel>());
            // Act
            TestModel testModel = new TestModel();
            testModel.Id = 10;
            testModel.Name = "MyName";
            testModel.Identifier = new Guid("00000000-0000-0000-0000-000000000001");
            ActionResult<TestModel> result = controller.Post(testModel);
            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Result, typeof(CreatedAtActionResult));
            CreatedAtActionResult createdAtActionResult = (CreatedAtActionResult)result.Result; 
            Assert.AreEqual(createdAtActionResult.ActionName, "Get");
            Assert.AreEqual(createdAtActionResult.StatusCode, 201);
            Assert.IsInstanceOfType(createdAtActionResult.Value, typeof(TestModel));
            TestModel createTestModel = (TestModel)createdAtActionResult.Value;
            Assert.IsTrue(createTestModel.Id == testModel.Id);
            Assert.IsTrue(createTestModel.Name == testModel.Name);
        }

    }
}
