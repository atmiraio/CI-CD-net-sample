using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using WebApi.DevOps.Controllers;

namespace WebApi.DevOps.Test
{
    public class EnviromentControllerTest
    {
        private Mock<ILogger<EnviromentController>> _mockLogger;
        private Mock<IConfiguration> _mockConfig;

        [SetUp]
        public void Setup()
        {
            _mockLogger = new Mock<ILogger<EnviromentController>>();
            _mockConfig = new Mock<IConfiguration>();
            
        }

        [Test]
        public void GetEnviromentsTest()
        {
            EnviromentController controller = new EnviromentController(_mockLogger.Object, _mockConfig.Object);
            var result = controller.GetEnviroments();

            Assert.IsNotNull(result);
        }

        [Test]
        public void CheckEnviromentTest()
        {
            _mockConfig.SetupGet(m => m[It.Is<string>(s => s == "Config:Enviroment")]).Returns("Testing");
            EnviromentController controller = new EnviromentController(_mockLogger.Object, _mockConfig.Object);
            var result = controller.CheckEnviroment();

            Assert.AreEqual("The active enviroment is Testing", result);
        }
    }
}
